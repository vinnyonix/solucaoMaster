using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace solucaoDomain.Entities
{
    public class Servico
    {
        [Key]
        public int IDServico { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public DateTime DataServico { get; set; }
        public string Descricao { get; set; }
        public List<Arquivo> Anexos { get; set; }
    }
}