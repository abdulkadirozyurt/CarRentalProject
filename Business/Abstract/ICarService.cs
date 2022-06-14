using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();

        List<Car> GetAllByBrandId(int brandId);
        List<Car> GetAllByColorId(int colorId);

        void Add(Car car);
    }
}
