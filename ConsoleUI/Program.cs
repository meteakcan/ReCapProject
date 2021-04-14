using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {/*
        static void Main(string[] args)
        {
            //CarTest();
            //ColorTest();
            //BrandTest();
            //CarAddTest();
            //ColorAddTest();
            //BrandAddTest();
            //UserAddListTest();
            //CustomerAddListTest();
            //RentalAddListTest();

        }

        private static void RentalAddListTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result2 = rentalManager.Add(new Rental { RentDate = new DateTime(1900, 01, 01), ReturnDate = new DateTime(1900, 01, 01) });
            var result = rentalManager.GetAll();
            Console.WriteLine(result2.Message);
            if (result.Success == true)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine("Araba Id : " + rental.CarId + " Kiralanma Tarihi : " + rental.RentDate + " Teslim Etme Tarihi" + rental.ReturnDate);
                }
                Console.WriteLine(result.Message);
            }
        }

        private static void CustomerAddListTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result2 = customerManager.Add(new Customer { CompanyName = "Şirket" });
            var result = customerManager.GetAll();
            Console.WriteLine(result2.Message);
            if (result.Success == true)
            {
                foreach (var customer in result.Data)
                {
                    Console.WriteLine(customer.CustomerId + "-" + customer.CompanyName);
                }
                Console.WriteLine(result.Message);
            }
        }

        private static void UserAddListTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result2 = userManager.Add(new User { FirstName = "Mete", LastName = "Akcan", Email = "meteakcan41@gmail.com", Password = "123456789" });
            var result = userManager.GetAll();
            Console.WriteLine(result2.Message);
            if (result.Success == true)
            {
                foreach (var user in result.Data)
                {
                    Console.WriteLine(user.UserId + "-" + user.FirstName + " " + user.LastName + "/" + user.Password + "/" + user.Email);
                }
                Console.WriteLine(result.Message);
            }
        }

        private static void BrandAddTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result2 = brandManager.Add(new Brand { BrandName = "Eklenecek marka" });
            var result = brandManager.GetAll();
            Console.WriteLine(result2.Message);
            if (result.Success == true)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandId + "-" + brand.BrandName);
                }
                Console.WriteLine(result.Message);
            }
        }

        private static void ColorAddTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result2 = colorManager.Add(new Color { ColorName = "Eklenecek renk" });
            var result = colorManager.GetAll();
            Console.WriteLine(result2.Message);
            if (result.Success == true)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorId + "-" + color.ColorName);
                }
                Console.WriteLine(result.Message);
            }
        }

        private static void CarAddTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result2 = carManager.Add(new Car { Description = "Eklenecek araba", ModelYear = 9999, Price = 9999 });
            var result = carManager.GetAll();
            Console.WriteLine(result2.Message);
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Description + "\n");
                }
                Console.WriteLine(result.Message);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();
            if (result.Success == true)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorId + "-" + color.ColorName);
                }
                Console.WriteLine(result.Message);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            if (result.Success==true)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandId + "-" + brand.BrandName);
                }
                Console.WriteLine(result.Message);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("id : " + car.CarId + "\nYıl : " + car.ModelYear + "\nÜcret : " + car.Price + "\nAçıklama : " + car.ColorId);
                }
                Console.WriteLine(result.Message);
            }
        }*/
    }
}
        