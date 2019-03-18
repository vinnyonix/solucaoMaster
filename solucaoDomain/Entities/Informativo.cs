using solucaoDomain.Entities.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucaoDomain.Entities
{
    public class Informativo
    {
        [Key]
        public int IDInformativo { get; set; }
        public DateTime DataCadastro { get; set; }
        [Display(Name = "Título")]
        public string Titulo { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "Status")]
        public StatusInformativo StatusInformativo { get;set;}
    }
}
