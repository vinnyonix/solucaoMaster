using System;

namespace solucaoDomain.Entities
{
    public abstract class Pessoa
    {
        protected string Nome { get; set; }
        protected string Sobrenome { get; set; }
        protected char Sexo { get; set; }
        protected DateTime DataNascimento { get; set; }
        protected string Pai { get; set; }
        protected string Mae { get; set; }
    }
}