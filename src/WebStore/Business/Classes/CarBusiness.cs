using System.Collections.Generic;
using WebStore.Business.Interfaces;
using WebStore.Domain.Entities;
using WebStore.Domain.Interfaces;
using WebStore.Repository.Interfaces;

namespace WebStore.Business.Classes
{
    public class CarBusiness : ICarBusiness
    {
        private ICarRepository _repository;
        public CarBusiness(ICarRepository repository)
        {
            _repository = repository;
        }
        public IList<ICar> GetAllCars()
        {
            return _repository.GetList();
        }

        public void RegisterCar(ICar car)
        {
            _repository.Add(car);
        }

        public IList<ICar> SelectByManufacturer(string manufacturer)
        {
            return _repository.SelectByManufacturer(manufacturer);
        }
    }
}
