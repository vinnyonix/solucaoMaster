using System.Collections.Generic;

namespace solucaoDomain.Interfaces.Generic
{
    public interface IRepositoryGeneric<TEntity> where TEntity : class
    {
        void Adicionar(TEntity obj);
        TEntity ObterPorID(int id);
        IEnumerable<TEntity> ObterTodos();
        void Atualizar(TEntity obj);
        void Remover(TEntity obj);
        void Dispose();
    }
}
