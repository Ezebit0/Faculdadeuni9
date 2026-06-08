using System.ComponentModel.DataAnnotations;

namespace Checkpoint_8.Models
{
    public class Aluno
    {
        [Required(ErrorMessage = "Nome obrigatório")]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Email obrigatório")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "RA obrigatório")]
        [StringLength(20)]
        public string RA { get; set; }

        [Required(ErrorMessage = "Curso obrigatório")]
        [StringLength(50)]
        public string Curso { get; set; }

        [Required(ErrorMessage = "Data de nascimento obrigatória")]
        public DateTime DataNascimento { get; set; }
    }
}