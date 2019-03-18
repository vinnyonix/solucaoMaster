using solucaoData.Interfaces.DAO.Generic;
using System;
using System.Collections.Generic;

namespace solucaoData.RepositoriesDAO.Generic
{
    public class RepositoryDAOGeneric<T> : IDisposable,  IRepositoryDAOGeneric<T> where T : class
    {
        public void Adicionar(T obj)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(T obj)
        {
            throw new NotImplementedException();
        }

        public T ObterPorID(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(T obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
