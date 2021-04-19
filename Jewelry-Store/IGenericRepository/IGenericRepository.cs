using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Jewelry_Store.IGenericRepository
{
    public interface IGenericRepository<T>where T:class
    {
        IEnumerable<T> GetAll();
        void Insert(T Obj);
        void Update(T entity);
        void Delete(object id);
        T GetSingleOrDefault(Expression<Func<T, bool>> whereCondition);
    }
}
