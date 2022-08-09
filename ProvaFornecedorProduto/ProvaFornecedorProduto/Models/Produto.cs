using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProvaFornecedorProduto.Models
{
    public class Produto
    {
        public long ProdutoId { get; set; }
        public long FornecedorId { get; set; } 
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public Fornecedor Fornecedor { get; set; }

    }
}