using System;

namespace solucaoDomain.Entities
{
    public class Enquete
    {
        public int IDEnquete { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Pergunta { get; set; }
        public bool Ativo { get; set; }
    }
}
