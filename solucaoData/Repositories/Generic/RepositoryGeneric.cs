using solucaoData.Context;
using solucaoDomain.Interfaces.Generic;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace solucaoData.Repositories.Generic
{
    public class RepositoryGeneric<TEntity> : IDisposable, IRepositoryGeneric<TEntity> where TEntity : class
    {
        protected Contexto banco = new Contexto();

        public void Adicionar(TEntity obj)
        {
            banco.Set<TEntity>().Add(obj);
            banco.SaveChanges();
        }

        public TEntity ObterPorID(int id)
        {
            return banco.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return banco.Set<TEntity>().ToList();
        }

        public void Atualizar(TEntity obj)
        {
            banco.Entry(obj).State = EntityState.Modified;
            banco.SaveChanges();
        }

        public void Remover(TEntity obj)
        {
            banco.Set<TEntity>().Remove(obj);
            banco.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
