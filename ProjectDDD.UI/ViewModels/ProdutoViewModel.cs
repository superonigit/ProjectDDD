using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectDDD.UI.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome.")]
        [MinLength(10, ErrorMessage = "Mínimo de {0} caracteres")]
        [MaxLength(150, ErrorMessage = "Máximo de {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o descrição.")]
        [MinLength(10, ErrorMessage = "Mínimo de {0} caracteres")]
        [MaxLength(150, ErrorMessage = "Máximo de {0} caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Informe o preco")]
        [Range(typeof(decimal), "0", "9999")]
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }

        [ScaffoldColumn(false)]
        public DateTime Inclusao { get; set; }

        [DisplayName("Disponível?")]
        public bool Disponivel { get; set; }

        public int ClienteId { get; set; }
        public virtual ClienteViewModel Cliente { get; set; }

    }
}