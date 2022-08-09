using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmailTrab.Models
{
    [Table("Aluno")]
    public class Aluno
    {
        [Key]
        public long Id { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }
        
        public Endereco Enderecos { get; set; }
    }
}
