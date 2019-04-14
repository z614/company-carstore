using System;
using System.Collections.Generic;

namespace Company.Carstore.Api.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int NumOfMiles { get; set; }
        public int NumOfSeats { get; set; }
        public string Category { get; set; }
    }
}