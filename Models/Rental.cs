using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_vehicle_rental.Models
{
    public class Rental
    {
        public List<Vehicle> vehicles = new List<Vehicle>();
        public int RentalId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int RentalValue { get; set; }
    }
}