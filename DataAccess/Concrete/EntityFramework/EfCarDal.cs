using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentacarContext>, ICarDal
    {
        public List<CarDetailDto> getCarDetail()
        {
            using (RentacarContext context = new RentacarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.Id
                             join o in context.Colors on c.ColorId equals o.Id
                             select new CarDetailDto
                             {
                                 BrandName = b.BrandName,
                                 ColorName = o.ColorName,
                                 ModelYear = c.ModelYear
                             };

                return result.ToList();

            }
        }
    }
}
