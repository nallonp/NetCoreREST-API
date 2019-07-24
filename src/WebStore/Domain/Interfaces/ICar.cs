using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain.Base;

namespace WebStore.Domain.Interfaces
{
    public interface ICar : IGenericEntity<ICar>
    {
        string Year { get; set; }
        string Manufacturer { get; set; }
        string Model { get; set; }
    }
}
