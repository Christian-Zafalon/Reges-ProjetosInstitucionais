using Fornecedores.Models;

namespace Fornecedores.Data
{
    public class AppDBInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppCont>();
                context.Database.EnsureCreated();

                //Criar tarefas
                if (!context.Fornecedor.Any())
                {
                    context.Fornecedor.AddRange(new List<Fornecedor>()
                    {
                        new Fornecedor()
                        {
                            RazaoSocial = "ZafalonCompani",
                            NomeFantasia = "ZafasLend",
                            Email = "zafa.zafa@gmail.com",
                            Telefone = "991075965",
                            NomeContato = "Christian",
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
