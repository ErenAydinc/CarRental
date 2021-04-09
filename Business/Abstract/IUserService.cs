using Core.Entites.Concrete;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);
        void Add(User user);
        IDataResult <List<User>> GetAll();

        IDataResult<List<User>> GetUsersById(int id);

    }
}
