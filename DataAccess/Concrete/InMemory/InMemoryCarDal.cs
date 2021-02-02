using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=250,ModelYear="2010",Description="Araçlarımız temiz ve bakımlıdır!"},
                new Car{CarId=2,BrandId=1,ColorId=1,DailyPrice=275,ModelYear="2014",Description="Araçlarımız temiz ve bakımlıdır!"},
                new Car{CarId=3,BrandId=2,ColorId=3,DailyPrice=300,ModelYear="2016",Description="Araçlarımız temiz ve bakımlıdır!"},
                new Car{CarId=4,BrandId=3,ColorId=4,DailyPrice=320,ModelYear="2018",Description="Araçlarımız temiz ve bakımlıdır!"},
                new Car{CarId=5,BrandId=1,ColorId=2,DailyPrice=260,ModelYear="2013",Description="Araçlarımız temiz ve bakımlıdır!"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
            _cars.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int carId)
        {
            return _cars.SingleOrDefault(c => c.CarId == carId);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.CarId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
