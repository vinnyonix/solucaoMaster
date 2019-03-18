using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace solucaoDomain.Entities
{
    public class Endereco
    {
        [Key]
        public int IDEndereco { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        [DisplayName("Número")]
        public int Numero { get; set; }
        public int CEP { get; set; }
    }
}