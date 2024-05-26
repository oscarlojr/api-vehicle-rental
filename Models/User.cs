using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_vehicle_rental.Models
{
    public class User
    {
        public List<Rental> rentals = new List<Rental>();
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
    }
}