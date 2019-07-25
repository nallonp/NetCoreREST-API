using System.Collections.Generic;
using WebStore.Domain.Entities;

namespace WebStore.Service.Interfaces
{
    public interface ICarService
    {
        void Add(Car car);
        void Update(Car car);
        void Delete(string guid);
        IEnumerable<Car> GetAll();
        IEnumerable<Car> SearchByMaker(string maker);
    }
}
