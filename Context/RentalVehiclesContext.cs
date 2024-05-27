using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_vehicle_rental.Models;
using Microsoft.EntityFrameworkCore;

namespace api_vehicle_rental.Context
{
    public class RentalVehiclesContext(DbContextOptions<RentalVehiclesContext> options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; } 
        
    }
}