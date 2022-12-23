using DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMomery
{
    public class InMomeryProductDal : ICarDal
    {

        List<Car> _products;

        public InMomeryProductDal()
        {
            _products = new List<Car> {
                new Car {Id = 1,BrandId=15 ,ColorId=157,DailyPrice=500,Description="Aracımız son derece kalitelidir",ModelYear="2020" },
                new Car {Id = 2,BrandId=15, ColorId=126,DailyPrice=300,Description="Aracımız aile aracıdır",ModelYear="2015" },
                new Car {Id = 3,BrandId=7 ,ColorId=145,DailyPrice=250,Description="Aracımız da sigara icilmesine izin verilmiyor",ModelYear="2016" },
                new Car {Id = 4,BrandId=8 ,ColorId=146,DailyPrice=1000,Description="Aracımız isteğiniz kadar hız yapabilirsiniz",ModelYear="2022" },
                new Car {Id = 5,BrandId=2 ,ColorId=146,DailyPrice=850,Description="Aracımız da hiç bir eksik yoktur",ModelYear="2018" },
            };
        }


        public void Add(Car products)
        {
            _products.Add(products);
        }

        public void Delete(Car products)
        {
            Car ProductToDelete = ProductToDelete = _products.SingleOrDefault(p => p.Id == products.Id); //foreach la aynı görevi yapar
            _products.Remove(ProductToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }


        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _products;
        }

        public List<Car> GetByLd(int Id)
        {
            return _products.Where(p => p.Id == p.Id).ToList();
        }

        public void Update(Car products)
        {
            Car ProductToUpdate = ProductToUpdate = _products.SingleOrDefault(p => p.Id == products.Id);
            ProductToUpdate.Id = ProductToUpdate.Id;
            ProductToUpdate.ModelYear = ProductToUpdate.ModelYear;
            ProductToUpdate.Description = ProductToUpdate.Description;
            ProductToUpdate.DailyPrice = ProductToUpdate.DailyPrice;
            ProductToUpdate.ColorId = ProductToUpdate.ColorId;
            ProductToUpdate.BrandId = ProductToUpdate.BrandId;

        }

    }


}

