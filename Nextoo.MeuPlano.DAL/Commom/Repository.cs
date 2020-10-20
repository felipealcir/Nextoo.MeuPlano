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
        protected ConnectionContext _context;
        protected DbSet<TEntity> DbSet;

        protected Repository(ConnectionContext context)
        {
            _context = context;
            DbSet = _context.Set<TEntity>();
        }

        public virtual void Adicionar(TEntity obj)
        {
            DbSet.Add(obj);
            SaveChanges();
        }

        public virtual void Atualizar(TEntity obj)
        {
            DbSet.Update(obj);
            SaveChanges();
        }

        public virtual IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.AsNoTracking().Where(predicate);
        }

        public virtual IEnumerable<TEntity> BuscarTodos()
        {
            return DbSet.ToList();
        }

        public virtual void Remover(decimal id)
        {
            DbSet.Remove(DbSet.Find(id));
            SaveChanges();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
