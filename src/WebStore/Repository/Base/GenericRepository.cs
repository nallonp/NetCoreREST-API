using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain.Base;
using WebStore.Repository.Interface;

namespace WebStore.Repository.Base
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : IGenericEntity<T>
    {
        private IList<T> _data;
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
            t.Guid = Guid.NewGuid();
            _data.Add(t);
        }

        public IList<T> GetList()
        {
            return _data;
        }
    }
}
