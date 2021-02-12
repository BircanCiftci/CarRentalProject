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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarDataBaseContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarDataBaseContext context = new CarDataBaseContext())
            {
                var result2 = from r in context.Rentals
                              join c in context.Customers
                              on r.CustomerId equals c.CustomerId
                              join ca in context.Cars
                              on r.CarId equals ca.CarId
                              join b in context.Brands
                              on ca.BrandId equals b.BrandId
                              join u in context.Users
                              on c.UserId equals u.UserId
                              select new RentalDetailDto
                              {
                                  RentalId = r.RentalId,
                                  FirstName = u.FirstName, LastName = u.LastName, Email =u.Email, Password = u.Password,
                                  BrandName = b.BrandName,
                                  CompanyName = c.CompanyName, RentDate = r.RentDate
                              };
                return result2.ToList();
            }
        }
    }
}
