using ProvaFornecedorProduto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProvaFornecedorProduto.Context
{ 
 public class EFContext : DbContext
{
    public EFContext() : base("TRABALHO")
    {
        Database.SetInitializer<EFContext>
            (new DropCreateDatabaseIfModelChanges<EFContext>());
    }

    public DbSet<Produto> Produtos { get; set; }

    public DbSet<Fornecedor> Fornecedores { get; set; }

}
}