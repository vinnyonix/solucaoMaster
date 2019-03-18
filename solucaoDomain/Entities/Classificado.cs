using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace solucaoDomain.Entities
{
    public class Classificado
    {
        [Key]
        public int IDClassificado { get; set; }
        [Required(ErrorMessage = "Você deve informar um título.")]
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        
        public decimal Preco { get; set; }
        public bool Status { get; set; }
    }
}
