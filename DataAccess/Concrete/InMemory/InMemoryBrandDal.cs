using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll()
        {
            return _brands;
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Brand GetById(int brandId)
        {
            return _brands.SingleOrDefault(b => b.BrandId == brandId);
        }

        public void Update(Brand entity)
        {
            throw new NotImplementedException();
        }
    }
}
