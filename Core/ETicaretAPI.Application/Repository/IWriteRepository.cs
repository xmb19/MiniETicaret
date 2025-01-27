using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repository
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync (T model);
        Task<bool> AddRangeAsync(List<T> model);
        Task<bool> Remove(T moodel);
        Task<bool> Remove(string id);
        bool UpdateAsync(T model);

    }
}
