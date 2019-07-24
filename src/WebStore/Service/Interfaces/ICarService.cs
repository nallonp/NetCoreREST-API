using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain.Entities;
using WebStore.Domain.Interfaces;

namespace WebStore.Service.Interfaces
{
    public interface ICarService
    {
        void Add(ICar car);
        IList<ICar> ListAll();
        IList<ICar> FindByManufacturer(string manufacturer);
    }
}
