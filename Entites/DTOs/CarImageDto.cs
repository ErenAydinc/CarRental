﻿using Core.Entities;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarImageDto:IDto
    {
        public string Description { get; set; }

        public string ColorName { get; set; }
        public int CarId { get; set; }
        public string BrandName { get; set; }
        public string ModelYear { get; set; }
        public string ImagePath { get; set; }
        public decimal DailyPrice { get; set; }
        public DateTime? Date { get; set; }
    }
}
