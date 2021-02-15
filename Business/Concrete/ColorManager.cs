using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager:IColorService
    {
        private IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }


        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IDataResult<Color> GetById(int colorId)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.Id == colorId));
        }

        public IResult Add(Color color)
        {
            Console.WriteLine("Renk Eklendi");
            _colorDal.Add(color);
            return new SuccessResult();
        }

        public IResult Delete(Color color)
        {
            Console.WriteLine("Renk Silindi");
            _colorDal.Delete(color);
            return new SuccessResult();
        }

        public IResult Update(Color color)
        {
            Console.WriteLine("Renk güncellendi");
            _colorDal.Update(color);
            return new SuccessResult();
        }
    }
}
