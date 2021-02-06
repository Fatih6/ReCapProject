﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            if (brand.BrandName.Length > 2)
            {
                _brandDal.add(brand);
                Console.WriteLine("Marka başarıyla eklendi.");
            }
            else
            {
                Console.WriteLine($"Üzgünüm,markayı ekleyemediniz.Lütfen yazdığınız marka isminin uzunluğunu 2 karakterden fazla giriniz! Girdiğiniz marka ismi : {brand.BrandName}");
            }
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine("Marka başarıyla silindi.");
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int brandId)
        {
            return _brandDal.Get(b => b.BrandId == brandId);
        }

        public void Update(Brand brand)
        {
            if (brand.BrandName.Length > 2)
            {
                _brandDal.Update(brand);
                Console.WriteLine("Marka başarıyla Güncellndi.");
            }
            else
            {
                Console.WriteLine($"Üzgünüm,marka güncellenemedi.Lütfen yazdığınız marka isminin uzunluğunu 2 karakterden fazla giriniz! Girdiğiniz marka ismi : {brand.BrandName}");
            }
        }
    }
}
