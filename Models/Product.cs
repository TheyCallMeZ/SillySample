using System;
using System.Collections.Generic;

#nullable disable

namespace SillySample.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Msrp { get; set; }
        public int? VendorId { get; set; }
    }
}
