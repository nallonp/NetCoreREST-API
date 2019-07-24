using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain.Base;

namespace WebStore.Repository.Interface
{
    public interface IGenericRepository<T> 
    {
        IList<T> GetList();
        void Add(T t);
    }
}
