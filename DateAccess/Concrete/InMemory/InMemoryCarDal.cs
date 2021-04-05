using DateAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DateAccess.Concrete
{

    /* public class InMemoryCarDal /*: ICarDal
     {
         /*
         List<Car> _cars;

         public InMemoryCarDal()
         {
             _cars = new List<Car>
             {
                 new Car{ Id=1,BrandId=1,ColorId=1,ModelYear="1999",DailyPrice=200,Description="Renault"},
                 new Car{ Id=2,BrandId=2,ColorId=2,ModelYear="1999",DailyPrice=300,Description="Mercedes"},
                 new Car{ Id=3,BrandId=1,ColorId=1,ModelYear="1999",DailyPrice=400,Description="Renault"},
             };
         }
         public void Add(Car car)
         {
             _cars.Add(car);
         }

         public void Delete(Car car)
         {
             Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
             _cars.Remove(carToDelete);
         }

         public Car Get(Expression<Func<Car, bool>> filter)
         {
             throw new NotImplementedException();
         }

         public List<Car> GetAll()
         {
             return _cars;
         }

         public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
         {
             throw new NotImplementedException();
         }

         public List<Car> GetById(int Id)
         {
             return _cars.Where(c => c.Id == Id).ToList();
         }

         public List<CarDetailDto> GetCarDetails()
         {
             throw new NotImplementedException();
         }

         public void Update(Car car)
         {
             Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
             carToUpdate.ModelYear = car.ModelYear;
             carToUpdate.Description = car.Description;
             carToUpdate.DailyPrice = car.DailyPrice;
             carToUpdate.ColorId = car.ColorId;
             carToUpdate.BrandId = car.BrandId;

         }

     }
     */
}

