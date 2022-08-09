using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmailTrab.Data;
using EmailTrab.Models;

namespace EmailTrab.Controllers
{
    public class AlunosController : Controller
    {
        private readonly EFContext _context;

        public AlunosController(EFContext context)
        {
            _context = context;
        }

        // GET: Alunos
        public async Task<IActionResult> Index()
        {
            var alunolista = await _context.Aluno.
                        Include(a => a.Enderecos).ToListAsync();
            var alunodec = alunolista.Where(a => a.Email == "hencrer@gmail.com").First();
            alunodec.Nome = Criptografia.Decriptor(alunodec.Nome);
            
            alunolista.Add(alunodec);
            return View(alunolista);
        }

        // GET: Alunos/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.Aluno == null)
            {
                return NotFound();
            }

            var aluno = await _context.Aluno
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aluno == null)
            {
                return NotFound();
            }

            return View(aluno);
        }

        // GET: Alunos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Alunos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Email,Enderecos")] Aluno aluno)
        {


            Endereco endereco = new Endereco();
            endereco = aluno.Enderecos;

            Aluno aluno_insert = new()
            {
                Nome = Criptografia.Encript( aluno.Nome),
                Email = aluno.Email
            };

            var alunoe = _context.Add<Aluno>(aluno_insert);

            await _context.SaveChangesAsync();

            endereco.AlunoId = aluno_insert.Id;
            //endereco.IdEndereco = null;

            _context.Add<Endereco>(endereco);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

        }

        // GET: Alunos/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.Aluno == null)
            {
                return NotFound();
            }

            var aluno = await _context.Aluno.FindAsync(id);
            if (aluno == null)
            {
                return NotFound();
            }
            return View(aluno);
        }

        // POST: Alunos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Nome,Email")] Aluno aluno)
        {
            if (id != aluno.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(aluno);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlunoExists(aluno.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            return View(aluno);
        }

        // GET: Alunos/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.Aluno == null)
            {
                return NotFound();
            }

            var aluno = await _context.Aluno
                .FirstOrDefaultAsync(m => m.Id == id);
            if (aluno == null)
            {
                return NotFound();
            }

            return View(aluno);
        }

        // POST: Alunos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.Aluno == null)
            {
                return Problem("Entity set 'EFContext.Aluno'  is null.");
            }
            var aluno = await _context.Aluno.FindAsync(id);
            if (aluno != null)
            {
                _context.Aluno.Remove(aluno);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlunoExists(long id)
        {
            return (_context.Aluno?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
