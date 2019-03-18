using solucaoDomain.Entities;
using solucaoDomain.Interfaces.Generic;
using System.Collections.Generic;

namespace solucaoDomain.Interfaces
{
    public interface IClassificadoRepository : IRepositoryGeneric<Classificado>
    {
        IEnumerable<Classificado> BuscarPorNome(string nome);
    }
}
