using Contacts;
using Phonebook;
using Phonebook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;



namespace Repository
{
    public abstract class RepositoryBase<T> : Phonebook.IRepositoryBase<T> where T : class
    {
        protected Phonebook11Context Phonebook11Context { get; set; }

        public RepositoryBase(Phonebook11Context phonebook11Context)
        {
            this.Phonebook11Context = phonebook11Context;
        }

        public IEnumerable<T> FindAll()
        {
            return this.Phonebook11Context.Set<T>();
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.Phonebook11Context.Set<T>().Where(expression);
        }

        public void Create(T entity)
        {
            this.Phonebook11Context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.Phonebook11Context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.Phonebook11Context.Set<T>().Remove(entity);
        }

        public void Save()
        {
            this.Phonebook11Context.SaveChanges();
        }
    }
}