using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sendEmail.Models;
using sendEmail.Services;

namespace sendEmail.Controllers
{
    public class EnvioEmailController : Controller
    {
        private readonly sendEmail.Services.IEmailSender _emailSender;
        // GET: EnvioEmailController
        public EnvioEmailController(sendEmail.Services.IEmailSender emailSender)
        {
            _emailSender = _emailSender;
        }

        // GET: EnvioEmailController/Details/5
        public ActionResult EnviaEmail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EnviarEmail(Email email)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    TesteEnvioEmail(email.Destino, email.Assunto, email.Mensagem);
                    return RedirectToAction("EmailEnviado");
                }
                catch (Exception ex)
                {
                    return RedirectToAction("EmailFalhou");
                }

            }
            return View(email);
        }

        private void TesteEnvioEmail(string email, string assunto, string mensagem)
        {
            try
            {
                var teste = _emailSender.SendEmailAsync(email, assunto, mensagem);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ActionResult EmailEnviado()
        {
            return View();
        }

        public ActionResult EmailFalhou()
        {
            return View();
        }
    }
}
