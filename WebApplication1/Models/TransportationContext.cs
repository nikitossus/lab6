using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class TransportationContext : DbContext
    {
        public DbSet<Tb_Companies> Tb_Companies { get; set; }
        public DbSet<Tb_Transportation> Tb_Transportation { get; set; }
        public DbSet<Tb_Transport> Tb_Transport { get; set; } 

        public class TranDbInitializer : DropCreateDatabaseAlways<TransportationContext>
        {
            protected override void Seed(TransportationContext context)
            {
                context.Tb_Companies.Add(new Tb_Companies { CompName = "Djullia", Director = "Katerina", CountOfTransp = 1231});
                context.Tb_Companies.Add(new Tb_Companies { CompName = "Fludia", Director = "Florida", CountOfTransp = 3424 });
                context.Tb_Companies.Add(new Tb_Companies { CompName = "Nutella", Director = "Clark", CountOfTransp = 533 });
                context.Tb_Companies.Add(new Tb_Companies { CompName = "Snickers", Director = "LOl", CountOfTransp = 23 });

                context.Tb_Transportation.Add(new Tb_Transportation { DriverName = "Volodia", GoodsComp = "Lol", Distance = 2423 });
                context.Tb_Transportation.Add(new Tb_Transportation { DriverName = "Paradentos", GoodsComp = "Kek", Distance = 2525 });
                context.Tb_Transportation.Add(new Tb_Transportation { DriverName = "Volodia", GoodsComp = "Clark", Distance = 123 });
                context.Tb_Transportation.Add(new Tb_Transportation { DriverName = "Paradentos", GoodsComp = "Cheburek", Distance = 646 });

                base.Seed(context);
            }
        }
    }
}