using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarShow.Models;

namespace CarShow.Data
{
    public class CarShowContext : DbContext
    {
        public CarShowContext (DbContextOptions<CarShowContext> options)
            : base(options)
        {
        }

        public DbSet<CarShow.Models.Car> Car { get; set; } = default!;
    }
}
