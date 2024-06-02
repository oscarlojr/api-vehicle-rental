using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_vehicle_rental.Models
{
    public class Vehicle : BaseEntity
    {
        public EnumStatusVehicle Status { get; set; }
        public string VehicleBrand { get; set; }
        public string VehicleModel { get; set; }
        public string VehicleLicensePlate { get; set; }
        public int VehicleYear { get; set; }
    }
}