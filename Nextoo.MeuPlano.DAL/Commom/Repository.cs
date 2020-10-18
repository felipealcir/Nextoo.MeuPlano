using Nextoo.MeuPlano.DAL.Commom.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Nextoo.MeuPlano.DAL.Commom
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public void Adicionar(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity BuscarPorID(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
