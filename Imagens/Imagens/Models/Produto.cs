using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imagens.Models
{
    public class Produto
    {
        [Key]
        public Guid Id { get; set; }
        [Column("Nome")]
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public byte[]? Foto { get; set; }
    }
}
