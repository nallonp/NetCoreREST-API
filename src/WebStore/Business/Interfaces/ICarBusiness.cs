using System.Collections.Generic;
using WebStore.Domain.Entities;

namespace WebStore.Business.Interfaces
{
    public interface ICarBusiness
    {
        void Add(Car car);
        void Update(Car car);
        void Delete(string guid);
        Car FindByGuid(string guid);
        IEnumerable<Car> GetAll();
        IEnumerable<Car> FindByMaker(string maker);
    }
}
