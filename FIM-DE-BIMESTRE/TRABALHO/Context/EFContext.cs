using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TRABALHO.Models;

namespace TRABALHO.Context
{
    public class EFContext : DbContext
    {
        public EFContext() : base("Escola") { }
        public DbSet<Aluno> Alunos { get; set; }
    }
}