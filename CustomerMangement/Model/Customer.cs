﻿using System.ComponentModel.DataAnnotations;

namespace CustomerMangement.Model
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Phoneno { get; set; }
    }
}
