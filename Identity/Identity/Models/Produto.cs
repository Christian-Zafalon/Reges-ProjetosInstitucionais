using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Identity.Models
{
    [Owned, Table("Produto")]
    public class Produto
    {
        [Display(Name = "Nome do Produto")]
        public string Nome { get; set; }
        public string Preco { get; set; }
    }
}
