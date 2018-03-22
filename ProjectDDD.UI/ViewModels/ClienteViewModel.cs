using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectDDD.UI.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome.")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        [MaxLength(150, ErrorMessage = "Máximo de {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o sobrenome.")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        [MaxLength(150, ErrorMessage = "Máximo de {0} caracteres")]
        public string Sobrenome { get; set; }

        [Required]
        [EmailAddress(ErrorMessage ="Informe email válido.")]
        [MinLength(3, ErrorMessage = "Mínimo de {0} caracteres")]
        [MaxLength(150, ErrorMessage = "Máximo de {0} caracteres")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime Inclusao { get; set; }

        public bool Ativo { get; set; }

        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}