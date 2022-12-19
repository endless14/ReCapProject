using DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMomery
{
    public class InMomeryProductDal : IProductDal
    {

        List<Products> _products;
        
        public InMomeryProductDal()
        {
            _products = new List<Products> {
                new Products {Id = 1,BrandId=15 ,ColorId=157,DailyPrice=500,Description="Aracımız son derece kalitelidir",ModelYear="2020" },
                new Products {Id = 2,BrandId=15, ColorId=126,DailyPrice=300,Description="Aracımız aile aracıdır",ModelYear="2015" },
                new Products {Id = 3,BrandId=7 ,ColorId=145,DailyPrice=250,Description="Aracımız da sigara icilmesine izin verilmiyor",ModelYear="2016" },
                new Products {Id = 4,BrandId=8 ,ColorId=146,DailyPrice=1000,Description="Aracımız isteğiniz kadar hız yapabilirsiniz",ModelYear="2022" },
                new Products {Id = 5,BrandId=2 ,ColorId=146,DailyPrice=850,Description="Aracımız da hiç bir eksik yoktur",ModelYear="2018" },
            };
        }

         
        public void Add(Products products)
        {
            _products.Add(products);
        }

        public void Delete(Products products)
        {
            Products ProductToDelete = ProductToDelete = _products.SingleOrDefault(p => p.Id == products.Id); //foreach la aynı görevi yapar
            _products.Remove(ProductToDelete);
        }

      

        public List<Products> GetAll()
        {
            return _products;
        }

        public List<Products> GetByLd(int Id)
        {
            return _products.Where(p =>p.Id == p.Id).ToList();
        }

        public void Update(Products products)
        {
            Products ProductToUpdate = ProductToUpdate = _products.SingleOrDefault(p => p.Id == products.Id);
            ProductToUpdate.Id = ProductToUpdate.Id;
            ProductToUpdate.ModelYear = ProductToUpdate.ModelYear;
            ProductToUpdate.Description = ProductToUpdate.Description;
            ProductToUpdate.DailyPrice = ProductToUpdate.DailyPrice;
            ProductToUpdate.ColorId = ProductToUpdate.ColorId;
            ProductToUpdate.BrandId = ProductToUpdate.BrandId;

        }

    }

      
}

