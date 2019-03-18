using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace solucaoDomain.Entities
{
    public class EstacionamentoVisitante
    {
        [Key]
        public int IDEstacionamentoVisitante { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public string Identificacao { get; set; }
        [DisplayName("Liberador")]
        public int IDMorador { get; set; }
        public string Vaga { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
    }
}