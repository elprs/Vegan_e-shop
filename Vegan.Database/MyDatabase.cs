using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Vegan.Entities.Home;

namespace Vegan.Database
{
   public  class MyDatabase : DbContext
   {
        public MyDatabase() : base("Connection")
        {
           
        }

        public DbSet<Candle> Candles { get; set; }
        public DbSet<Chocolate> Chocolates { get; set; }
        public DbSet<Home> Homes { get; set; }
      
    }
}
