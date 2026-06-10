using System.ComponentModel.DataAnnotations;

namespace Uninove.Web.Models
{
    public class Aluno
    {
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string RA { get; set; }

        [Required]
        public string Curso { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }
    }
}