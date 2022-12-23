using Business.Abstrack;
using DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    class ColorManager : IColorService
    {
        IColorDal _ColorDal;

        public ColorManager(IColorDal ColorDal)
        {
            _ColorDal = ColorDal;
        }


        public void Add(Color color)
        {
            _ColorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _ColorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _ColorDal.GetAll();
        }

        public List<Color> GetByColorId(int colorId)
        {
            return _ColorDal.GetAll(p => p.ColorId == colorId);
        }

        public void Uptade(Color color)
        {
            _ColorDal.Update(color);
        }
    }
}
