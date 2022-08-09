using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalMVCCore.Models
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }

        [Column("nome_curso")]
        [Required(ErrorMessage = "Este campo é obrigatorio!")]
        [DisplayName("Nome do Curso")]
        public string nome { get; set; }

        public Curso curso { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio!")]
        [DisplayName("Materia")]
        public string materia { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio!")]
        [DisplayName("Carga Horaria")]
        public string cargaHoraria { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio!")]
        [DisplayName("Nivel")]
        public string nivel { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatorio!")]
        [DisplayName("Valor")]
        public int valor { get; set; }


    }
}
