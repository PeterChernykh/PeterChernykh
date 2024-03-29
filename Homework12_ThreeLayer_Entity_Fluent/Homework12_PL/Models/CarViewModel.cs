﻿using System.Collections.Generic;

namespace Homework12_PL.Models
{
    public class CarViewModel
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public IEnumerable<DetailViewModel> Details { get; set; }
    }
}
