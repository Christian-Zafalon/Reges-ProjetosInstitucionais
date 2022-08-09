using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Identity.Data;
using Identity.Models;

namespace Identity.Controllers
{
    public class FornecedoresController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FornecedoresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Fornecedores
        public async Task<IActionResult> Index()
        {
            var listadefornecedor = await _context.DbFornecedor.
            Include(a => a.ProdutoFornecedor).ToListAsync();

            return View(listadefornecedor);

            //return _context.DbFornecedor != null ? 
            //            View(await _context.DbFornecedor.ToListAsync()) :
            //            Problem("Entity set 'ApplicationDbContext.DbFornecedor'  is null.");
        }

        // GET: Fornecedores/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.DbFornecedor == null)
            {
                return NotFound();
            }

            var fornecedor = await _context.DbFornecedor
                .FirstOrDefaultAsync(m => m.IdFornecedor == id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            return View(fornecedor);
        }

        // GET: Fornecedores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Fornecedores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Cnpj,ProdutoFornecedor")] Fornecedor fornecedor)
        {
            var fornecer = _context.Add<Fornecedor>(fornecedor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

            ////   if (ModelState.IsValid)
            //   {
            //       _context.Add(fornecedor);
            //       await _context.SaveChangesAsync();
            //       return RedirectToAction(nameof(Index));
            //   }
            //   return View(fornecedor);
        }

        // GET: Fornecedores/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.DbFornecedor == null)
            {
                return NotFound();
            }

            var fornecedor = await _context.DbFornecedor.FindAsync(id);
            if (fornecedor == null)
            {
                return NotFound();
            }
            return View(fornecedor);
        }

        // POST: Fornecedores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("IdFornecedor,Nome,Cnpj, ProdutoFornecedor")] Fornecedor fornecedor)
        {
            if (id != fornecedor.IdFornecedor)
            {
                return NotFound();
            }

      //      if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fornecedor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FornecedorExists(fornecedor.IdFornecedor))
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
           // return View(fornecedor);
        }

        // GET: Fornecedores/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.DbFornecedor == null)
            {
                return NotFound();
            }

            var fornecedor = await _context.DbFornecedor
                .FirstOrDefaultAsync(m => m.IdFornecedor == id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            return View(fornecedor);
        }

        // POST: Fornecedores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.DbFornecedor == null)
            {
                return Problem("Entity set 'ApplicationDbContext.DbFornecedor'  is null.");
            }
            var fornecedor = await _context.DbFornecedor.FindAsync(id);
            if (fornecedor != null)
            {
                _context.DbFornecedor.Remove(fornecedor);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FornecedorExists(long id)
        {
          return (_context.DbFornecedor?.Any(e => e.IdFornecedor == id)).GetValueOrDefault();
        }
    }
}
