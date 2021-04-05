using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {

        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<CarDetailDto>> GetAll();
        IDataResult<List<Car>> GetCarsById(int Id);
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int Id);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<CarDetailDto>> GetCarsByBrandIdDetail(int brandId);
        IDataResult<List<CarDetailDto>> GetCarsByColorIdDetail(int colorId);
        IDataResult<List<CarDetailDto>> GetCarsByBrandIdAndColorId(int brandId,int colorId);


    }
}
