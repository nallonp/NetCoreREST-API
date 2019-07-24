using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain.Entities;
using WebStore.Domain.Interfaces;
using WebStore.Repository.Interface;

namespace WebStore.Repository.Interfaces
{
    public interface ICarRepository : IGenericRepository<ICar>
    {
        IList<ICar> SelectByManufacturer(string carMaker);
    }
}
