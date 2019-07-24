using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domain.Entities;
using Xunit;

namespace WebStore.Tests.Domain.Entities
{
    public class CarTest
    {
        [Theory]
        [InlineData("1994", "Ford", "Focus")]
        void Sucess(string year, string maker, string model)
        {
            Car car = new Car()
            {
                Year = year,
                Maker = maker,
                Model = model
            };
            Assert.True(car.Year == year && car.Model == model && car.Maker == maker);
        }
    }
}
