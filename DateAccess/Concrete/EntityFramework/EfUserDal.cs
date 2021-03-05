using Core.DataAccess.EntityFramework;
using DateAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Core.Entites.Concrete;
using Core.Entities.Concrete;

namespace DateAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, CarRentalContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context=new CarRentalContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                             on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };

                return result.ToList();
            }
        }
    }
}
