using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            RentalTest();
            UserTest();
            CustomerTest();
            CarImageManager carImageManager = new CarImageManager(new EfCarImageDal());

            foreach (var carImage in carImageManager.GetAll().Data)
            {
                Console.WriteLine(carImage.CarId + " / " + carImage.CarImageId + " / " + carImage.ImagePath + " / " + carImage.Date);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + " / " + car.ColorName + " / " + car.Description + " / " + car.ModelYear + " / " + car.DailyPrice + " / " + car.CarImages);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result2 = rentalManager.GetRentalDetails();

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
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName + " / " + user.LastName + " / " + user.Email + " / " + user.Password);
            }
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(customer.UserId + " / " + customer.CompanyName);
            }
        }
    }
}
