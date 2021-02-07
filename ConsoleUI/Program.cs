using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManagerGetAll();

            //BrandManagerAll();

            CarManager carManager = new CarManager(new EfCarDal());
            
            foreach (var carDetail in carManager.GetCarDetail())
            {
                Console.WriteLine($"{carDetail.BrandName} -- {carDetail.ColorName} -- {carDetail.ModelYear}");
            }
        }

        private static void BrandManagerAll()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            var result = brandManager.GetById(3);
            Console.WriteLine(result.BrandName);

            //brandManager.Insert(new Brand{BrandName = "Tofaş"});

            //brandManager.Delete(new Brand{Id = 1002});

            brandManager.Update(new Brand {Id = 1003, BrandName = "Şahin"});

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarManagerGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.BrandId);
            }
        }
    }
}
