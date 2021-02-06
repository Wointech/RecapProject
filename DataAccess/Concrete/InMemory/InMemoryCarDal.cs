using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
            
            new Car{Id=1,BrandId=3,ColorId=1,ModelYear="2015",DailyPrice=150,Description="Rental car"},
            new Car{Id=2,BrandId=1,ColorId=1,ModelYear="2012",DailyPrice=100,Description="Rental car"},
            new Car{Id=3,BrandId=4,ColorId=2,ModelYear="2020",DailyPrice=400,Description="Rental car"},
            new Car{Id=4,BrandId=3,ColorId=4,ModelYear="2016",DailyPrice=180,Description="Rental car"},
            new Car{Id=5,BrandId=2,ColorId=1,ModelYear="2010",DailyPrice=100,Description="Rental car"},
            new Car{Id=6,BrandId=2,ColorId=3,ModelYear="2011",DailyPrice=100,Description="Rental car"},
            new Car{Id=7,BrandId=1,ColorId=2,ModelYear="2017",DailyPrice=300,Description="Rental car"},
            new Car{Id=8,BrandId=1,ColorId=1,ModelYear="2018",DailyPrice=300,Description="Rental car"},

            };
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Car car)
        {
            _cars.Add(car);

        }

        public void Delete(Car car)
        {
            Car deleteToCar = _cars.SingleOrDefault(c=>c.Id == car.Id);

            _cars.Remove(deleteToCar);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int BrandId)
        {
            return _cars.Where(c => c.BrandId == BrandId).ToList();
        }

        public void Update(Car car)
        {
            Car updateToCar = _cars.SingleOrDefault(c=>c.Id==car.Id);

            updateToCar.BrandId = car.BrandId;
            updateToCar.ColorId = car.ColorId;
            updateToCar.DailyPrice = car.DailyPrice;
            updateToCar.Description = car.Description;
            updateToCar.ModelYear = car.ModelYear;
        }
    }
}
