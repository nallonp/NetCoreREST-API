using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain.Base;

namespace WebStore.Repository.Interface
{
    public interface IGenericRepository<T> 
    {
        IEnumerable<T> GetList();
        T FindByGuid(Guid guid);
        void Add(T t);
        void Update(T t);
        void Delete(T t);
    }
}
