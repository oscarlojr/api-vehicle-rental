using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_vehicle_rental.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string VehicleBrand { get; set; }
        public string VehicleModel { get; set; }
        public string VehicleLicensePlate { get; set; }
        public int VehicleYear { get; set; }
        public EnumStatusVehicle Status { get; set; }
    }
}