using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solucaoData.Interfaces.DAO.Generic
{
    /// tipo do objeto que será manipulador pela DAO
    public interface IRepositoryDAOGeneric<T>  where T : class //new()
    {
        T ObterPorID(int id);
        void Adicionar(T obj);
        IEnumerable<T> ObterTodos();
        void Atualizar(T obj);
        void Remover(T obj);
        void Dispose();
    }
}
