using Business.Abstrack;
using DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _CarDal;

        public CarManager(ICarDal CarDal)
        {
            _CarDal = CarDal;
        }

        public IEnumerable<object> GetCarsByBrandId(int v)
        {
            throw new NotImplementedException();
        }

        public void Add(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice > 0) ;
            _CarDal.Add(car);
                Console.WriteLine("Araç eklendi");
        }

        public void Delete(Car car)
        {

            _CarDal.Delete(car);
            Console.WriteLine(car.Id+"id ' li araç silindi");
        }

        public List<Car> GetAll()
        {
            return _CarDal.GetAll();
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _CarDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max);
        }

        public List<Car> GetById(int id)
        {
            return new List<Car>(_CarDal.GetAll(p => p.Id == id));
        }

        public List<Car> GetCarsBrandId(int id)
        {
            return _CarDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _CarDal.GetAll(p => p.ColorId == id);
        }

        public void Update(Car car)
        {
            if  (car.Description.Length >= 2 && car.DailyPrice > 0)
            {
                _CarDal.Update(car);
                Console.WriteLine(car.Id + "ID'li Araç Bilgisi Güncellendi");
            }
            else
            {
                throw new Exception("araç adı boş olamaz ve günlük fiat 0 den büyük olmalı");
            }
            
        }
    }


}
