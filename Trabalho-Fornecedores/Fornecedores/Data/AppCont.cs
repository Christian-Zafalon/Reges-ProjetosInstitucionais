using Fornecedores.Models;
using Microsoft.EntityFrameworkCore;

namespace Fornecedores.Data
{
    public class AppCont : DbContext
    {
        public AppCont(DbContextOptions<AppCont> options) : base(options)
        {
        }

        public DbSet<Fornecedor> Fornecedor { get; set; }
    }
}