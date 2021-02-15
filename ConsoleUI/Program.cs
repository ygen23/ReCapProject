using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetCarByIdTest(2);
            //GetCarsByBrandId(2);
            //BrandNameTest();
            //ColorNameTest();
            //CarDetailsTest();
            //GetAll();
            //AddCustomer();
            //AddUser();
            AddRental();
            //GetRentalDetails();
        }

        private static void GetRentalDetails()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetRentalDetails();
            if (result.Success)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(rental.BrandName+" "+rental.Description + " " +
                        rental.FirstName + " " +rental.LastName + " " +
                        rental.RentDate + " " +rental.ReturnDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void AddRental()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result=rentalManager.Add(new Rental {
            CarId=2,
            CustomerId=4,
            RentDate=System.DateTime.Now
            }
            );
            Console.WriteLine(result.Message);
        }

        private static void AddUser()
        {
            
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(
            new User { FirstName = "halil",LastName = "kıvırcık",Email = "hk34@icloud.com",Password = "456963"}
            );
           var result=userManager.GetAll();
            if (result.Success)
            {
                foreach (var user in result.Data)
                {
                    Console.WriteLine(user.FirstName+" "+user.LastName+" "+user.Email);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void AddCustomer()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer{UserId = 1, CompanyName = "ygen23"}
            );
            var result = customerManager.GetAll();
            if (result.Success)
            {
                foreach (var customer in result.Data)
                {
                    Console.WriteLine(customer.UserId+" "+customer.CompanyName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
        private static void GetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetCarsByBrandId(int id)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarsByBrandId(id);
            if (result.Success)
            {
            foreach (var car in result.Data)
                        {
                            Console.WriteLine(car.Description);
                        }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }

        private static void GetCarByIdTest(int id)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarById(id);
            if (result.Success)
            {
                    Console.WriteLine(result.Data.Description);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        
        private static void BrandNameTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            if (result.Success)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void ColorNameTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();
            if (result.Success)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarId + " " + car.BrandName + " " + 
                            car.Description + " " + car.ColorName + " " + 
                            car.ModelYear + " " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
          
        }
    }
}
