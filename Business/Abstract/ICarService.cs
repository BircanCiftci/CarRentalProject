﻿using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<Car> GetAll();
        List<Car> GetAllByBrandAll(int id);
        List<Car> GetAllByColorAll(int id);
        List<Car> GetByDailyPrice(float min, float max);

        List<CarDetailDto> GetCarDetails();
    }
}
