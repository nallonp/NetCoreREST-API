using System.Collections.Generic;
using WebStore.Domain.Base;
using WebStore.Repository.Interface;
using System.Linq;
using System;
using WebStore.Infrastructure.DB;
using Dapper;

namespace WebStore.Repository.Base
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : IGenericEntity<T>
    {
        private readonly List<T> _data;
        private static object _syncObj_list = new object();

        public GenericRepository()
        {
            if (_data == null)
                lock (_syncObj_list)
                    if (_data == null)
                        _data = new List<T>();
        }

        public void Add(T t)
        {
            _data.Add(t);
        }
        public void Update(T t)
        {
            var index = _data.FindIndex(x => x.Guid.Equals(t.Guid));
            if (index >= 0)
                _data[index] = t;
            else
                throw new ArgumentException("Objeto não encontrado.");
        }
        public void Delete(T t)
        {
            _data.Remove(t);
        }
        public IEnumerable<T> GetList()
        {
            using (var conn = ConnectionFactory.GetConnection())
            {
                try
                {
                    conn.Open();
                    var result = conn.Query<T>("Select * from Car").ToList();
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
        public T FindByGuid(Guid guid)
        {
            return _data.Find(x=>x.Guid==guid);
        }
    }
}
