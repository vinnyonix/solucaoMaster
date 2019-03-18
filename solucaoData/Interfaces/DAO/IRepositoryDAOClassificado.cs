using solucaoData.Interfaces.DAO.Generic;
using solucaoDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucaoData.Interfaces.DAO
{

    public interface IRepositoryDAOClassificado : IRepositoryDAOGeneric<Classificado>
    {
        IEnumerable<Classificado> BuscarPorNome(string nome);
    }

}
