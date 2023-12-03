﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Bitirme.Models
{
    public class Explore
    {

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string ProductKg { get; set; }
        public string Note { get; set; }

    }
}