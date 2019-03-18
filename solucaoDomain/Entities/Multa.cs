using solucaDomain.Entities.Utilities;
using System;
using System.ComponentModel.DataAnnotations;

namespace solucaoDomain.Entities
{
    public class Multa
    {
        public int IDNotificacao { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public int IDMorador { get; set; }
        public int IDArtigo { get; set; }
        public TipoInfracao Infracao { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public string Contestacao { get; set; }
        public string Parecer { get; set; }
        public string Notificacao1 { get; set; }
        public string Notificacao2 { get; set; }
    }
}