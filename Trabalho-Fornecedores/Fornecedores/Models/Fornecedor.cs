using System.ComponentModel.DataAnnotations;

namespace Fornecedores.Models
{
    public class Fornecedor

    {
        [Key]
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string NomeContato { get; set; }
    }
}

