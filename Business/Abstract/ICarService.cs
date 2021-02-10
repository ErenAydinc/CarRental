using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        Car Get(int Id);
        List<Car> GetAll();
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);

        List<Car> GetCarsById(int Id);
        List<Car> GetCarsByBrandId(int Id);

        List<Car> GetCarsByColorId(int Id);
    }
}
