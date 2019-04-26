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
        public int Miles { get; set; }
        public int Seats { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }

        public void ChangeMiles(int miles)
        {
            this.Miles = miles;
        }

        public void ChangePrice(int price)
        {
            this.Price = price;
        }
    }
}
