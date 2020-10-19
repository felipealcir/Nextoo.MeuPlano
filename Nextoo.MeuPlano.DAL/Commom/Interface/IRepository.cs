using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Nextoo.MeuPlano.DAL.Commom.Interface
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity obj);       
        IEnumerable<TEntity> BuscarTodos();
        void Atualizar(TEntity obj);
        void Remover(Guid id);
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);       
    }
}
