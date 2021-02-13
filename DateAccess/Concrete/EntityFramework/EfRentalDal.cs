using Core.DataAccess.EntityFramework;
using DateAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DateAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntitiyRepositoryBase<Rental, CarRentalContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (CarRentalContext context=new CarRentalContext())
            {
                var result = from re in filter is null
                             ? context.Rentals : context.Rentals.Where(filter)
                             join c in context.Cars
                             on re.CarId equals c.Id
                             join cu in context.Customers
                             on re.CustomerId equals cu.Id
                             join us in context.Users
                             on cu.UserId equals us.Id
                             select new RentalDetailDto
                             {
                                 Id = re.Id,
                                 CarId = c.Id,
                                 CompanyName = cu.CompanyName,
                                 RentDate = re.RentDate,
                                 ReturnDate = re.ReturnDate,
                                 FirstName=us.FirstName,
                                 LastName=us.LastName
                             };
                return result.ToList();
            }
        }
    }
}
