using solucaDomain.Entities.Utilities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace solucaoDomain.Entities
{
    public class Funcionario : Pessoa
    {
        [Key]
        public int IDFuncionario { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public int IDEndereco { get; set; }
        [DisplayName("E-mail")]
        [EmailAddress]
        public string Email { get; set; }
        public double CPF { get; set; }
        public double RG { get; set; }
        public FuncionarioContrato Contrato { get; set; }
        public Setor Setor { get; set; }
        public Cargo Cargo { get; set; }
        public decimal Salario { get; set; }
        public Endereco Endereco { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public string Nacionalidade { get; set; }
        public string Naturalidade { get; set; }
        public int CTPS { get; set; }
        [DisplayName("Vale transporte")]
        public bool VT { get; set; }
        [DisplayName("Vale refeição")]
        public bool VR { get; set; }
        [DisplayName("Plano de Saúde")]
        public bool PS { get; set; }
    }
}