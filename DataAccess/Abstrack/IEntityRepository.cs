using Entities.Abstrack;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstrack
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter = null);//1 kere yaz yeter
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);


    }
}
