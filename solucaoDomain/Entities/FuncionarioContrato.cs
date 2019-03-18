using System;
using System.ComponentModel.DataAnnotations;

namespace solucaoDomain.Entities
{
    public class FuncionarioContrato
    {
        public int IDFuncionarioContrato { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public long NumeroContrato { get; set; }
        public DateTime DataContratacao { get; set; }
        public DateTime DataDemissao { get; set; }
    }
}