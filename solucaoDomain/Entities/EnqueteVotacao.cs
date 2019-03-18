using solucaoDomain.Entities.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucaoDomain.Entities
{
    public class EnqueteVotacao
    {
        public int IDEnqueteVotacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IDMorador { get; set; }
        public Voto Voto { get; set; }
    }
}
