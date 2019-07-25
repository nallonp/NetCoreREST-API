using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.Domain.Base
{
    public class GenericEntity<T> : IGenericEntity<T>
    {
        public Guid Guid { get; set; }

        public GenericEntity()
        {
            Guid = Guid.NewGuid();
        }
    }
}
