using Microsoft.EntityFrameworkCore;
using Nextoo.MeuPlano.DAL.Commom.Interface;
using Nextoo.MeuPlano.DAL.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Nextoo.MeuPlano.DAL.Commom
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected ConnectionContext Db;
        protected DbSet<TEntity> DbSet;

        protected Repository(ConnectionContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual void Adicionar(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public virtual void Atualizar(TEntity obj)
        {
            DbSet.Update(obj);
        }

        public virtual IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.AsNoTracking().Where(predicate);
        }

        public virtual IEnumerable<TEntity> BuscarTodos()
        {
            return DbSet.ToList();
        }

        public virtual void Remover(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
