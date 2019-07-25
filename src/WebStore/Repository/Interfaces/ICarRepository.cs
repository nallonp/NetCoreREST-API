using System.Collections.Generic;
using WebStore.Domain.Entities;
using WebStore.Repository.Interface;

namespace WebStore.Repository.Interfaces
{
    public interface ICarRepository : IGenericRepository<Car>
    {
        IList<Car> FindByMaker(string maker);
    }
}
