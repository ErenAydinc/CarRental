using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
        IResult CarRentable(int Id);
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetById(int Id);
        IDataResult<List<Rental>> GetRentalsByCustomerId(int Id);
        IDataResult<List<Rental>> GetRentalsByCarId(int Id);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
    }
}
