using System.Collections.Generic;
using WebStore.Business.Interfaces;
using WebStore.Domain.Entities;
using WebStore.Service.Interfaces;

namespace WebStore.Service.Classes
{
    public class CarService : ICarService
    {
        private ICarBusiness _business;
        public CarService(ICarBusiness business)
        {
            _business = business;
        }
        public IEnumerable<Car> GetAll()
        {
            return _business.GetAll();
        }
        public void Add(Car car)
        {
            _business.Add(car);
        }

        public void Update(Car car)
        {
            _business.Update(car);
        }

        public void Delete(string guid)
        {
            _business.Delete(guid);
        }
        public IEnumerable<Car> SearchByMaker(string maker)
        {
            return _business.FindByMaker(maker);
        }
    }
}
