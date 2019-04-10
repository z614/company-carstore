using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Company.Carstore.Api.Data;
using Company.Carstore.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Company.Carstore.Api.Controllers
{
    [Route("api/cars")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly CarstoreContext db;

        public CarsController(CarstoreContext db)
        {
           this.db = db;
            if (this.db.Cars.Count() == 0)
            {
                this.db.Cars.Add(new Car()
                {
                    Id = 1,
                    Make = "Jeep",
                    Model = "Liberty",
                    Year = 2010,
                    NumOfMiles = 98563,
                    NumOfSeats = 5,
                    Category = "SUV"
                });
               this.db.Cars.Add(new Car()
                {
                    Id = 2,
                    Make = "Ford",
                    Model = "Liberty",
                    Year = 2012,
                    NumOfMiles = 89652,
                    NumOfSeats = 5,
                    Category = "Sedan"
                });
            }
            this.db.SaveChanges();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(db.Cars);
        }

        [HttpGet("{id}", Name = "GetCar")]
        public IActionResult GetCar(int id)
        {
            var Car = db.Cars.FirstOrDefault(b => b.Id == id);

            if (Car == null)
            {
                return NotFound();
            }

            return Ok(Car);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Car car)
        {
            if (car == null)
            {
                return BadRequest();
            }

            db.Cars.Add(car);
            db.SaveChanges();

            return CreatedAtRoute("GetCar", new { id = car.Id }, car);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Car Car)
        {
            if (Car == null || Car.Id != id)
            {
                return BadRequest();
            }

            var CarToEdit = db.Cars.FirstOrDefault(b => b.Id == id);
            if (CarToEdit == null)
            {
                return NotFound();
            }

            CarToEdit.Make = Car.Make;
            CarToEdit.Model = Car.Model;
            CarToEdit.Year = Car.Year;
            CarToEdit.NumOfMiles = Car.NumOfMiles;
            CarToEdit.NumOfSeats = Car.NumOfSeats;
            CarToEdit.Category = Car.Category;

            this.db.Cars.Update(CarToEdit);
            this.db.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Car = db.Cars.FirstOrDefault(b => b.Id == id);

            if (Car == null)
            {
                return NotFound();
            }

            db.Cars.Remove(Car);
            db.SaveChanges();

            return NoContent();
        }
    }
}