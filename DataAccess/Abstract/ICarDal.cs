using Core.DataAccess;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal: IEntityRepository<Car>
    {
        List<CarDetailsDto> GetCarDetails();
    }
}
