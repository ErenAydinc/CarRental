using Core.DataAccess.EntityFramework;
using DateAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DateAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntitiyRepositoryBase<Car, CarRentalContext>, ICarDal
    {

        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from ca in filter is null ? context.Cars : context.Cars.Where(filter)
                             join co in context.Colors
                             on ca.ColorId equals co.ColorId
                             join b in context.Brands
                             on ca.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 Id = ca.Id,
                                 BrandId = b.BrandId,
                                 BrandName = b.BrandName,
                                 ColorId = co.ColorId,
                                 ColorName = co.ColorName,
                                 DailyPrice = ca.DailyPrice,
                                 Description = ca.Description,
                                 ModelYear = ca.ModelYear
                             };

                return result.ToList();



                //public void Add(Car entity)
                //{
                //    using(CarRentalContext context=new CarRentalContext())
                //    {
                //        var addedEntity = context.Entry(entity);
                //        addedEntity.State = EntityState.Added;
                //        context.SaveChanges();
                //    }
                //}

                //public void Delete(Car entity)
                //{
                //    using (CarRentalContext context = new CarRentalContext())
                //    {
                //        var deletedEntity = context.Entry(entity);
                //        deletedEntity.State = EntityState.Deleted;
                //        context.SaveChanges();
                //    }
                //}

                //public Car Get(Expression<Func<Car, bool>> filter)
                //{
                //    using (CarRentalContext context = new CarRentalContext())
                //    {
                //        return context.Set<Car>().SingleOrDefault(filter);
                //    }
                //}

                //public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
                //{
                //    using (CarRentalContext context = new CarRentalContext())
                //    {
                //        return filter == null
                //            ? context.Set<Car>().ToList()
                //            : context.Set<Car>().Where(filter).ToList();
                //    }
                //}

                //public void Update(Car entity)
                //{
                //    using (CarRentalContext context = new CarRentalContext())
                //    {
                //        var updatedEntity = context.Entry(entity);
                //        updatedEntity.State = EntityState.Modified;
                //        context.SaveChanges();
                //    }
                //}
            }
        }
    }
}
    
