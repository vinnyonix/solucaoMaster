using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace solucaoDomain.Entities
{
    public class Contrato
    {
        [Key]
        public int IDContrato { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        [DisplayName("Número")]
        public int NumeroContrato { get; set; }
        [DisplayName("Admissão")]
        public DateTime Admissao { get; set; }
        [DisplayName("Demissão")]
        public DateTime Demissao { get; set; }
    }
}