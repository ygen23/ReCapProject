using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;
        public InMemoryBrandDal()
        {
            _brands = new List<Brand> { 
            new Brand{BrandId=1,BrandName="RENAULT"},
            new Brand{BrandId=2,BrandName="DACİA"},
            new Brand{BrandId=3,BrandName="FORD"},
            new Brand{BrandId=4,BrandName="FİAT"},
            new Brand{BrandId=5,BrandName="VOLVO"}
            };
        }
        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public void Delete(Brand brand)
        {
            Brand brandToDelete = _brands.SingleOrDefault(b=>b.BrandId==brand.BrandId);
        }

        public List<Brand> GetAll()
        {
            return _brands;
        }

        public Brand GetById(int brandId)
        {
            return _brands.SingleOrDefault(b => b.BrandId == brandId);
        }
    }
}
