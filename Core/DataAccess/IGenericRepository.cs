using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    public interface IGenericRepository<TEntity> where TEntity : class,new()
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
    }
}
