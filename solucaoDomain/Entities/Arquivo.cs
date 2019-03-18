using System;
using System.ComponentModel.DataAnnotations;

namespace solucaoDomain.Entities
{

    public class Arquivo
    {
        [Key]
        public int IDArquivo { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public string NomeDoArquivo { get; set; }
        public string Tipo { get; set; }
        public string Caminho { get; set; }
        public string Tamanho { get; set; }
    }
}