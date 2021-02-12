using Business.Concrete;
using DataAccess.Concrete.Entity_Framework;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            var result = carManager.GetCarDetails();
            var result2 = rentalManager.GetRentalDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + " / " + car.ColorName + " / " + car.Description + " / " + car.ModelYear + " / " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            Console.WriteLine("***********************************************************************************************");

            if (result2.Success == true)
            {
                foreach (var rental in result2.Data)
                {
                    Console.WriteLine(rental.FirstName + " / " + rental.LastName + " / " + rental.BrandName + " / " + rental.CompanyName + " / " + rental.RentDate 
                        + " / " + rental.ReturnDate + " / " + rental.Email + " / " + rental.Password);
                }
            }
            else
            {
                Console.WriteLine(result2.Message);
            }

            Console.WriteLine("***********************************************************************************************");

            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName + " / " + user.LastName + " / " + user.Email + " / " + user.Password);
            }

            Console.WriteLine("***********************************************************************************************");

            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(customer.UserId +" / " + customer.CompanyName);
            }
        }
    }
}
