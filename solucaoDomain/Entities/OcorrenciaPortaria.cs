using solucaDomain.Entities.Utilities;
using System;
using System.ComponentModel.DataAnnotations;

namespace solucaoDomain.Entities
{
    public class OcorrenciaPortaria
    {
        [Key]
        public int IDOcorrencia { get; set; }
        [ScaffoldColumn(false)]
        public TipoDeOcorrenciaPortaria TipoDeOcorrenciaPortaria { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Descricao { get; set; }
    }
}