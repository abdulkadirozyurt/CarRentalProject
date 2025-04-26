using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice != 0)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine(car.Description + " not providing requirements for adding.");
            }

            // if (car.CarName.Length > 2 && car.DailyPrice > 0)
            // {
            //     _carDal.Add(car);
            //     return new SuccessResult(Messages.CarAdded);
            // }

            // return new ErrorResult(Messages.CarNameInvalid);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed); // success  olduğu için true ibaresini kaldırınca rahatladı kızmadı. çünkü zaten true default
        }

        public IDataResult<List<Car>> GetAllByBrandId(int brandId)
        {
            return new DataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brandId), true, Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetAllByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId), Messages.CarsListed);
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == carId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            if (DateTime.Now.Hour == 00)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(), Messages.CarDetailsListed);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
