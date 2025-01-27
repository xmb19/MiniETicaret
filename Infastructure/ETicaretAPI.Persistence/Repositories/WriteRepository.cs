using ETicaretAPI.Application.Repository;
using ETicaretAPI.Domain.Entities.Common;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {

        readonly private ETicaretAPIDbContext _context;

        public WriteRepository(ETicaretAPIDbContext context)
        {
            _context = context;
        }


        public DbSet<T> Table => _context.Set<T>();

        public Task<bool> AddAsync(T model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddRangeAsync(List<T> model)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(T moodel)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(string id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateAsync(T model)
        {
            throw new NotImplementedException();
        }
    }

  
}

