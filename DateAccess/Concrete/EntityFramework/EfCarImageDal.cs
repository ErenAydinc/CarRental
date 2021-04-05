using Core.DataAccess.EntityFramework;
using DateAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DateAccess.Concrete.EntityFramework
{
    public class EfCarImageDal : EfEntityRepositoryBase<CarImage, CarRentalContext>, ICarImageDal
    {
        public List<CarImageDto> GetCarImageDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from i in context.CarImages
                             join c in context.Cars
                             on i.CarId equals c.Id
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             select new CarImageDto
                             {
                                 CarId=c.Id,
                                 BrandName=b.BrandName,
                                 ColorName=co.ColorName,
                                 ModelYear=c.ModelYear,
                                 Description = c.Description,
                                 ImagePath=i.ImagePath,
                                 DailyPrice=c.DailyPrice,
                                 Date=i.Date
                             };

                return result.ToList();
            }

        }

        public bool IsExist(int id)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                return context.CarImages.Any(p => p.Id == id);
            }
        }


    }
}
