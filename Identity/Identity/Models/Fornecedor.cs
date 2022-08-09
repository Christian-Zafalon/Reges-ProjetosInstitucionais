using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Identity.Models
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        [Key]
        public long IdFornecedor { get; set; }
        [Display(Name = "Nome do Fornecedor")]
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public Produto ProdutoFornecedor{ get; set; }
    }
}
