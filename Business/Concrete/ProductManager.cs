using Business.Abstrack;
using DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _ıProductDal;

        public ProductManager(IProductDal productDal)
        {
            _ıProductDal = productDal;
        }
        
        public List<Products> GetAll()
        {
            return _ıProductDal.GetAll();
        }
    }


}
