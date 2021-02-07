using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager:IBrandService
    {
        private IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }


        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int brandId)
        {
            return _brandDal.Get(b => b.Id == brandId);
        }

        public void Insert(Brand brand)
        {
            Console.WriteLine("Marka Eklendi");
            _brandDal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            Console.WriteLine("Marka Silindi");
            _brandDal.Delete(brand);
        }

        public void Update(Brand brand)
        {
            Console.WriteLine("Marka güncellendi");
            _brandDal.Update(brand);
        }
    }
}
