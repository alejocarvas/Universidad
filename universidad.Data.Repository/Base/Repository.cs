using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace universidad.Data.Repository.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected string _connectionString;

        public Repository(string connectionString)
        {
            _connectionString = connectionString;
            SqlMapperExtensions.TableNameMapper = (type) => { return $"{ type.Name }"; };
        }

        public async Task<bool> Delete(T entity)
        {
            using (var conecction = new SqlConnection(_connectionString))
            {
                return await conecction.DeleteAsync(entity);
            }
        }

        public async Task<IEnumerable<T>> Get()
        {
            using (var conecction = new SqlConnection(_connectionString))
            {
                return await conecction.GetAllAsync<T>();
            }
        }

        public async Task<T> GetById(int id)
        {
            using (var conecction = new SqlConnection(_connectionString))
            {
                return await conecction.GetAsync<T>(id);
            }
        }

        public async Task<int> Insert(T entity)
        {
            using (var conecction = new SqlConnection(_connectionString))
            {
                return await conecction.InsertAsync(entity);
            }
        }

        public async Task<bool> Update(T entity)
        {
            using (var conecction = new SqlConnection(_connectionString))
            {
                return await conecction.UpdateAsync(entity);
            }
        }
    }
}
