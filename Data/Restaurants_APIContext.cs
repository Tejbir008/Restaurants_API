using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Restaurants_API.Model;

namespace Restaurants_API.Data
{
    public class Restaurants_APIContext : DbContext
    {
        public Restaurants_APIContext (DbContextOptions<Restaurants_APIContext> options)
            : base(options)
        {
        }

        public DbSet<Restaurants_API.Model.Restaurant> Restaurant { get; set; }
    }
}
