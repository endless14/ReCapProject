using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstrack
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        List<Brand> GetByBrandId(int brandId);
        void Add(Brand brand);
        void Delete(Brand brand);
        void Update(Brand brand);

    }
}
