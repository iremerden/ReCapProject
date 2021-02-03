using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal() 
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=01,ColorId=001,ModelYear=2018,DailyPrice=500000,Description="Otomatik vites,Multimedyalı."},
                new Car{CarId=2,BrandId=02,ColorId=002,ModelYear=2015,DailyPrice=350000,Description="Otomatik vites,Multimedyalı."},
                new Car{CarId=3,BrandId=03,ColorId=003,ModelYear=2019,DailyPrice=648000,Description="Otomatik vites,Multimedyalı."},
                new Car{CarId=4,BrandId=04,ColorId=004,ModelYear=2020,DailyPrice=723000,Description="Otomatik vites,Multimedyalı."},
                new Car{CarId=5,BrandId=05,ColorId=005,ModelYear=2021,DailyPrice=982000,Description="Otomatik vites,Multimedyalı."},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int BrandId)
        {
           return _cars.Where(c=> c.BrandId == BrandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
