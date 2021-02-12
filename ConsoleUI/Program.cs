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
            CarManagerGetAll();

            //BrandManagerAll();

            //GetCarDetailManager();
        }

        private static void GetCarDetailManager()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetail();

            foreach (var carDetail in result.Data)
            {
                Console.WriteLine($"{carDetail.BrandName} -- {carDetail.ColorName} -- {carDetail.ModelYear}");
            }
        }

        private static void BrandManagerAll()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            var result = brandManager.GetById(3).Data;
            Console.WriteLine(result.BrandName);

            //brandManager.Insert(new Brand{BrandName = "Tofaş"});

            //brandManager.Delete(new Brand{Id = 1002});

            brandManager.Update(new Brand {Id = 1003, BrandName = "Şahin"});

            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarManagerGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.BrandId);
            }
        }
    }
}
