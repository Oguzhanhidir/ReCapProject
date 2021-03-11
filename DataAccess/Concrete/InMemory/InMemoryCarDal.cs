using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
   public class InMemoryCarDal: ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { Id=1, BrandId=1, ColorId=1, ModelYear="2017", DailyPrice=225, Description="Audi A3"  },
                new Car { Id=2, BrandId=1, ColorId=2, ModelYear="2021", DailyPrice=270, Description="Audi A3"  },
                new Car { Id=3, BrandId=2, ColorId=3, ModelYear="2020", DailyPrice=260, Description="Renault Megane"  },
                new Car { Id=4, BrandId=2, ColorId=4, ModelYear="2019", DailyPrice=250, Description="Renault Megane"  },
                new Car { Id=5, BrandId=3, ColorId=5, ModelYear="2018", DailyPrice=240, Description="Honda Civic"  },
            };
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public  List<Car> GetByld()
        {
            return _cars;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p =>p.Id == car.Id);
            _cars.Remove(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            
        }
    }
}
