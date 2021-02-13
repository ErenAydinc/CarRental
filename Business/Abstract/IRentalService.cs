using Core.Utilities.Results;
using Entites.Concrete;
using System;
using System.Collections.Generic;
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
    }
}
