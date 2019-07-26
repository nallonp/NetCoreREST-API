using System.Collections.Generic;
using System.Linq;
using WebStore.Domain.Entities;
using WebStore.Infrastructure.DB;
using WebStore.Repository.Base;
using WebStore.Repository.Interfaces;

namespace WebStore.Repository.Classes
{
    public class CarRepository : GenericRepository<Car>, ICarRepository
    {
        public CarRepository()
        {
            _factory = new ConnectionFactory();
        }
        public IList<Car> FindByMaker(string maker)
        {
            return GetList().Where(x => x.Maker == maker).ToList();
        }

    }
}
