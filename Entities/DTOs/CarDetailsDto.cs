using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.DTOs
{
    public class CarDetailsDto: IDto
    {
        public string CarName { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public int ColorId { get; set; }
        public string ColorName { get; set; }

    }
}
