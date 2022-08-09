using Microsoft.EntityFrameworkCore;
using ProjetoFinalMVCCore.Models;

namespace ProjetoFinalMVCCore.Data
{
    public class EFContext :DbContext
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {

        }

        public DbSet<Professor> Professor { get; set; }
        public DbSet <Curso> Curso { get; set; }
    }
}
