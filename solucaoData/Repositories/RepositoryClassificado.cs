using solucaoData.Repositories.Generic;
using solucaoDomain.Entities;
using solucaoDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucaoData.Repositories
{
    public class RepositoryClassificado : RepositoryGeneric<Classificado>, IClassificadoRepository
    {
        public IEnumerable<Classificado> BuscarPorNome(string titulo)
        {
            return banco.Classificados.Where(p => p.Titulo == titulo);
        }
    }
}
