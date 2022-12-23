using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstrack
{
    public interface ICarService
    {
        List<Car> GetById(int id);
        List<Car> GetAll();
        List<Car> GetCarsBrandId(int id);
        List<Car> GetCarsByColorId(int id);

        List<Car> GetByDailyPrice(decimal min, decimal max);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
    }
}
