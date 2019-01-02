using Contacts;
using Phonebook;
using Phonebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;




namespace Repository
{
    public abstract class RepositoryBase<TEntity> : Phonebook.IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly Phonebook11Context Context;

        public RepositoryBase(Phonebook11Context context)
        {
            Context = context;
        }
        public TEntity GetEntity(int contactId)
        {
            return Context.Set<TEntity>().Find(contactId);
        }

        public IEnumerable<TEntity> FindAll()
        {
            return this.Context.Set<TEntity>();
        }

        public IEnumerable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression)
        {
            return this.Context.Set<TEntity>().Where(expression);
        }

        public void Create(TEntity entity)
        {
            this.Context.Set<TEntity>().Add(entity);
        }

        public void Update(TEntity entity)
        {
            this.Context.Set<TEntity>().Update(entity);
        }

        public void Delete(TEntity entity)
        {
            this.Context.Set<TEntity>().Remove(entity);
        }

        public void Save()
        {
            this.Context.SaveChanges();
        }


        public void Add(TEntity entity)
        {
            this.Context.Set<TEntity>().Add(entity);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return this.Context.Set<TEntity>().ToList();

        }      
        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return this.Context.Set<TEntity>().Where(predicate);
        }

        public void Remove(TEntity entity)
        {
            this.Context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(TEntity entity)
        {
            this.Context.Set<TEntity>().RemoveRange(entity);
        }
    }

}