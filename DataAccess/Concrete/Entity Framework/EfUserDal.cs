using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Entity_Framework
{
    public class EfUserDal : EfEntityRepositoryBase<User, CarDataBaseContext>, IUserDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            throw new NotImplementedException();
        }
    }
}
