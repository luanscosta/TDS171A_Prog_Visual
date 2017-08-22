using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using TDS171A_Diogo.Models;

namespace TDS171A_Diogo.Context
{
    public class EFContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public EFContext()
            : base ("Asp_Net_MVC_CS")
        {
                
        }
    }
}