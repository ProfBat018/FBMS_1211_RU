using Ecommerce.Data.DbContexts;
using EcommerceDataAccess.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceDataAccess.Services.Classes
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ECommerceDbContext? _context;
        internal DbSet<T>? contextSet;

        public Repository(ECommerceDbContext? context)
        {
            _context = context;
            this.contextSet = _context!.Set<T>();
        }

        public void Add(T? entity)
        {
            contextSet!.Add(entity!);
        }

        public IEnumerable<T>? GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null)
        {
            IQueryable<T>? query = contextSet!;
            if (filter != null)
            {
                query = query!.Where(filter);
            }
            if (includeProperties != null)
            {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query!.Include(includeProp);
                }
            }
            return query.ToList()!;
        }

        public T? GetFirstOrDefault(Expression<Func<T, bool>>? filter, string? includeProperties = null, bool tracked = true)
        {
            if (tracked)
            {
                IQueryable<T>? query = contextSet!;

                query = query!.Where(filter!);

                if (includeProperties != null)
                {
                    foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        query = query!.Include(includeProp);
                    }
                }
                return query!.FirstOrDefault();
            }
            else
            {
                IQueryable<T>? query = contextSet!.AsNoTracking();

                query = query!.Where(filter!);
                if (includeProperties != null)
                {
                    foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        query = query!.Include(includeProp);
                    }
                }
                return query!.FirstOrDefault();
            }

        }

        public void Remove(T? entity)
        {
            contextSet!.Remove(entity!);
        }

        public void RemoveRange(IEnumerable<T>? entity)
        {
            contextSet!.RemoveRange(entity!);
        }
    }
}
