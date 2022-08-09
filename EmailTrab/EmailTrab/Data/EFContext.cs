using EmailTrab.Models;
using Microsoft.EntityFrameworkCore;

namespace EmailTrab.Data
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {

        }

        public DbSet <Aluno> Aluno{ get; set; }
        //public DbSet<Endereco> Endereco { get; set; }

    }
}
