﻿using Core.DataAccess.EntityFramework;
using DateAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DateAccess.Concrete.EntityFramework
{
    public class EfCustomerDal:EfEntitiyRepositoryBase<Customer,CarRentalContext>,ICustomerDal
    {
    }
}
