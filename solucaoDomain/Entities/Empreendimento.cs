using solucaDomain.Entities.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucaoDomain.Entities
{
    public class Empreendimento
    {
        [Key]
        public int IDEmpreendimento { get; set; }
        public string NomeEmpreendimento { get; set; }
        public double CNPJ { get; set; }
        public DateTime DataCadastro { get; set; }
        public StatusEmpreendimento Status { get; set; }
        public int IDEndereco { get; set; }
        public int Unidades { get; set; }
    }
}
