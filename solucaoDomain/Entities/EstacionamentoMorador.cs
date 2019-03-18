using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace solucaoDomain.Entities
{
    public class EstacionamentoMorador
    {
        [Key]
        public int IDEstacionamentoMorador { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        [DisplayName("Número")]
        public string Numero { get; set; }
        public int IDMorador { get; set; }
        [DisplayName("Observação")]
        public string Observacao { get; set; }
    }
}