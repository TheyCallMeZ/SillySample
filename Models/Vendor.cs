using System;
using System.Collections.Generic;

#nullable disable

namespace SillySample.Models
{
    public partial class Vendor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Contact { get; set; }
        public string ContactPhone { get; set; }
    }
}
