using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Business.Interfaces;
using WebStore.Domain.Entities;
using WebStore.Domain.Interfaces;
using WebStore.Service.Interfaces;
using ICar = WebStore.Domain.Interfaces.ICar;

namespace WebStore.Service.Classes
{
    public class CarService : ICarService
    {
        private ICarBusiness _business;
        public CarService(ICarBusiness business)
        {
            _business = business;
        }
        public IList<ICar> ListAll()
        {
            return _business.GetAllCars();
        }

        public void Add(ICar car)
        {
            _business.RegisterCar(car);
        }

        public IList<ICar> FindByManufacturer(string manufacturer)
        {
            return _business.SelectByManufacturer(manufacturer);
        }
    }
}
