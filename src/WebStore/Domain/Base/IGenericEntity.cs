using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.Domain.Base
{
    public interface IGenericEntity<T>
    {
        Guid Guid { get; set; }
    }
}
