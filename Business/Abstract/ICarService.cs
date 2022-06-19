using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();

        List<Car> GetAllByBrandId(int brandId);
        List<Car> GetAllByColorId(int colorId);

        List<CarDetailDto> GetCarDetails();

        void Add(Car car);
    }
}
