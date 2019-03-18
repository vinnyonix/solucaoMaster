using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace solucaoDomain.Entities
{
    public class Morador : Pessoa
    {
        [Key]
        public int IDMorador { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public string Status { get; set; }
        public int IDEmpreendimento { get; set; }
        public int IDEndereco { get; set; }
        public string Bloco { get; set; }
        public string Apto { get; set; }
        public int Numero { get; set; }
        [DisplayName("Fone 1")]
        public int Fone1 { get; set; }
        [DisplayName("Fone 2")]
        public int Fone2 { get; set; }
        [DisplayName("Fone 3")]
        public int Fone3 { get; set; }
        public bool RedesSociaisVisiveis { get; set; } //Tornar as redes visíveis à todos.
        [DisplayName("E-mail")]
        [EmailAddress]
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Youtube { get; set; }
        public string GooglePlus { get; set; }
    }
}