using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Phonebook
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> FindAll();

        TEntity GetEntity(int contactId);

        void Add(TEntity entity);

        IEnumerable<TEntity> Find(Expression<Func<TEntity,bool>> predicate);
        
        void Remove(TEntity entity);

        void RemoveRange(TEntity entity);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression);
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Save();
    }
}
        
        
        
        
        
    
