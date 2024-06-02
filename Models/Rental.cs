using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_vehicle_rental.Models
{
    public class Rental : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal RentalValue { get; set; }
    }
}