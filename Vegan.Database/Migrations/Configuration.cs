namespace Vegan.Database.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Vegan.Entities.Home;

    internal sealed class Configuration : DbMigrationsConfiguration<Vegan.Database.MyDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Vegan.Database.MyDatabase context)
        {
            Candle c1 = new Candle() { Title = "Candle1", Price = 1.1m, MyProperty = 1 };
            Candle c2 = new Candle() { Title = "Candle2", Price = 1.1m, MyProperty = 2 };
            Candle c3 = new Candle() { Title = "Candle3", Price = 1.1m, MyProperty = 3 };

            Chocolate ch1 = new Chocolate() { Title = "Chocolate1", Price = 1.1m, MyProperty = 1 };
            Chocolate ch2 = new Chocolate() { Title = "Chocolate2", Price = 1.1m, MyProperty = 2 };
            Chocolate ch3 = new Chocolate() { Title = "Chocolate3", Price = 1.1m, MyProperty = 3 };



            context.Candles.AddOrUpdate(x=>x.Title, c1, c2, c3);
            context.Chocolates.AddOrUpdate(x=>x.Title, ch1, ch2, ch3);
            context.SaveChanges();
        }
    }
}
