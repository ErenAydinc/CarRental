using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Entites.Concrete;
using Core.Utilities.Results;
using DateAccess.Abstract;
using DateAccess.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
         public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            if (car.Description.Length<2 || car.Description.Length <= 0)
            {
                return new ErrorResult(Messages.CarDescriptionInvaild);
            }
            
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);

        }


        public IResult Delete(Car car)
        {
            _carDal.Delete(car);

            return new SuccessResult(Messages.CarDeleted);
        }

        
        public IDataResult<List<CarDetailDto>> GetAll()
        {
            return new SuccessDataResult<List<CarDetailDto>> (_carDal.GetCarDetails());
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<CarDetailDto>> GetCarsByBrandIdDetail(int brandId)
        {
             return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails().Where(x => x.BrandId == brandId).ToList());
        }
        public IDataResult<List<CarDetailDto>> GetCarsByColorIdDetail(int colorId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails().Where(x => x.ColorId == colorId).ToList());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brandId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int Id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == Id));
        }

        public IDataResult<List<Car>> GetCarsById(int Id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.Id == Id));
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }

        public IDataResult<List<CarDetailDto>> GetCarsByBrandIdAndColorId(int brandId, int colorId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails().Where(x=>x.BrandId==brandId && x.ColorId==colorId).ToList());
        }
    }
}
