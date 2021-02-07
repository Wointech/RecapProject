using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
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


        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int colorId)
        {
            return _colorDal.Get(c => c.Id == colorId);
        }

        public void Insert(Color color)
        {
            Console.WriteLine("Renk Eklendi");
            _colorDal.Add(color);
        }

        public void Delete(Color color)
        {
            Console.WriteLine("Renk Silindi");
            _colorDal.Delete(color);
        }

        public void Update(Color color)
        {
            Console.WriteLine("Renk güncellendi");
            _colorDal.Update(color);
        }
    }
}
