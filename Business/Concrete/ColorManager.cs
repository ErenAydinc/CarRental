using Business.Abstract;
using DateAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public void Add(Color color)
        {
             _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public List<Color> GetCarsByBrandId(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetCarsByColorId(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);
        }
    }
}
