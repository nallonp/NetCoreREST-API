using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebStore.Domain.Entities;
using WebStore.Domain.Interfaces;
using WebStore.Repository.Base;
using WebStore.Repository.Interfaces;

namespace WebStore.Repository.Classes
{
    public class CarRepository : GenericRepository<ICar>, ICarRepository
    {
        public IList<ICar> SelectByMaker(string maker)
        {
            return GetList().Where(x => x.Maker == maker).ToList();
        }

    }
}
