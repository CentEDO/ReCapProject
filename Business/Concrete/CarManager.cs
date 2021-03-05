using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car car)
        {
            if (car.Description.Length<=2 && car.DailyPrice<=0)
            {
                Console.WriteLine("Your cars' name is not available. It must be minimum 2 characters and daily price must be over the 0!");
            }
            else if (car.Description.Length >= 2 && car.DailyPrice > 0)
            {
                Console.WriteLine("Your car is added!");
            }
            

        }

        public void Delete(Car car)
        {
            Console.WriteLine("Your car is deleted!");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetById(int id)
        {
            return _carDal.GetAll(c => c.Id == id);
        }

        public void Update(Car car)
        {
            
            Console.WriteLine("Your car is updated!");
        }
    }
}
