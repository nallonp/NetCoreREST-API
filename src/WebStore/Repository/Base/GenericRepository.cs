using System.Collections.Generic;
using WebStore.Repository.Interface;
using System;
using WebStore.Infrastructure.DB;
using Dapper.Contrib.Extensions;
using WebStore.Domain.Base;

namespace WebStore.Repository.Base
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : GenericEntity<T>
    {
        protected IConnectionFactory _factory;

        public void Add(T t)
        {
            using (var conn = _factory.GetConnection())
            {
                try
                {
                    conn.Open();
                    conn.Insert(t);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public void Update(T t)
        {
            using (var conn = _factory.GetConnection())
            {
                try
                {
                    conn.Open();
                    conn.Update(t);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public void Delete(T t)
        {
            using (var conn = _factory.GetConnection())
            {
                try
                {
                    conn.Open();
                    conn.Delete(t);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public IEnumerable<T> GetList()
        {
            using (var conn = _factory.GetConnection())
            {
                try
                {
                    conn.Open();
                    return conn.GetAll<T>();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public T FindByGuid(Guid guid)
        {
            using (var conn = _factory.GetConnection())
            {
                try
                {
                    conn.Open();
                    T result = conn.Get<T>(guid);
                    return result;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
