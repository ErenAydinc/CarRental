using Business.Abstract;
using DateAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public List<Brand> GetCarsByBrandId(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetCarsByColorId(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        List<Color> IBrandService.GetCarsByBrandId(int Id)
        {
            throw new NotImplementedException();
        }

        List<Color> IBrandService.GetCarsByColorId(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
