using DreamJourney.Data;
using DreamJourney.Data.Models;
using DreamJourney.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DreamJourney.Services
{
    public class BaseService<T> : IBaseService<T> where T : BaseModel, new()
    {
        protected readonly DreamJourneyDbContext dbContext;
        protected readonly DbSet<T> dbSet;

        public BaseService(DreamJourneyDbContext context)
        {
            dbContext = context;
            dbSet = context.Set<T>();
        }

        public void Delete(int id)
        {
            dbSet.Remove(GetById(id));

            dbContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public void Insert(T item)
        {
            dbSet.Add(item);

            dbContext.SaveChanges();
        }

        public void Update(T item)
        {
            T element = GetById(item.Id);

            if (element != null)
            {
                dbContext.Entry(element).State = EntityState.Detached;
            }

            dbContext.Entry(item).State = EntityState.Modified;

            dbContext.SaveChanges();
        }

    }
}
