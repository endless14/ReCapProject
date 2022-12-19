using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstrack
{
    public interface IProductDal
    {
        void Add(Products products);
        void Delete(Products products);
        void Update(Products products);
        List<Products> GetByLd( int DataAcces );
        List<Products> GetAll();

    }
}
