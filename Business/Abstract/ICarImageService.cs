﻿using Core.Utilities.Result;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(IFormFile file, CarImage carImage);
        IResult Delete(CarImage carImage);
        IResult Update(IFormFile file, CarImage carImage);
        IDataResult<List<CarImage>> GetCarImagesByCarId(int id);
        IDataResult<CarImage> GetById(int id);
        IDataResult<List<CarImage>> GetAll();
    }
}
