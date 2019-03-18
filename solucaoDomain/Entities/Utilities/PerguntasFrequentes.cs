using System;

namespace solucaDomain.Entities.Utilities
{
    public class PerguntasFrequentes
    {
        public int IDFACs { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Modulo { get; set; }
        public string Pergunta { get; set; }
        public string Resposta { get; set; }
    }
}