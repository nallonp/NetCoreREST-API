using System;
using System.Collections.Generic;
using WebStore.Business.Interfaces;
using WebStore.Domain.Entities;
using WebStore.Repository.Interfaces;

namespace WebStore.Business.Classes
{
    public class CarBusiness : ICarBusiness
    {
        private readonly ICarRepository _repository;
        public CarBusiness(ICarRepository repository)
        {
            _repository = repository;
        }
        public void Add(Car car)
        {
            _repository.Add(car);
        }

        public void Delete(string guid)
        {
            var car = FindByGuid(guid);
            _repository.Delete(car);
        }

        public Car FindByGuid(string guid)
        {
            return _repository.FindByGuid(Guid.ParseExact(guid, "N"));
        }

        public IEnumerable<Car> GetAll()
        {
            return _repository.GetList();
        }

        public void Update(Car car)
        {
            _repository.Update(car);
        }
        public IEnumerable<Car> FindByMaker(string maker)
        {
            return _repository.FindByMaker(maker);
        }
    }
}
