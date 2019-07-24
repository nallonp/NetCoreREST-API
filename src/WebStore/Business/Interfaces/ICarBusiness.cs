using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain.Entities;
using WebStore.Domain.Interfaces;

namespace WebStore.Business.Interfaces
{
    public interface ICarBusiness
    {
        void RegisterCar(ICar car);
        IList<ICar> SelectByManufacturer(string manufacturer);
        IList<ICar> GetAllCars();
    }
}
