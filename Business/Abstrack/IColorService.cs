using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstrack
{
    interface IColorService
    {
        List<Color> GetAll();
        List<Color> GetByColorId(int colorId);
        void Add(Color color);
        void Delete(Color color);
        void Uptade(Color color);
    }
}
