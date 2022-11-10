using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace universidad.Data.Repository.Base
{
    public interface IRepository<T> where T : class
    {
        Task<bool> Delete(T entity);
        Task<bool> Update(T entity);
        Task<int> Insert(T entity);
        Task<IEnumerable<T>> Get();
        Task<T> GetById(int id);
    }
}
