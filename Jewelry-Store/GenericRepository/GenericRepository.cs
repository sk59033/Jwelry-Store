using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jewelry_Store.IGenericRepository;
using Jewelry_Store;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace JewelryStore.GenericRepository
{
    public class GenericRepository<T>:IGenericRepository<T>where T:class
    {
        private readonly ApplicationContext context;
        private DbSet<T> entities;
        public GenericRepository(ApplicationContext context)
        {
            this.context = context;
            entities = context.Set<T>();

        }
        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }
        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Delete(object id)
        {
            if (id == null)
            {
                throw new ArgumentNullException("entity");
            }
            T entity = entities.Find(id);
            if (entity != null)
            {
                entities.Remove(entity);
                context.SaveChanges();
            }
        }
        public T GetSingleOrDefault(Expression<Func<T, bool>> whereCondition)
        {
            return entities.Where(whereCondition).FirstOrDefault();
        }
    }
}
