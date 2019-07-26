using Dapper.Contrib.Extensions;
using System;

namespace WebStore.Domain.Base
{
    public class GenericEntity<T> : IGenericEntity<T>
    {
        [Key]
        public Guid Guid { get; set; }
    }
}
