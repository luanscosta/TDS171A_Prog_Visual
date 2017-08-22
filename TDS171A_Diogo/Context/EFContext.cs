using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace TDS171A_Diogo.Context
{
    public class EFContext : DbContext
    {
        public EFContext()
            : base ("Asp_Net_MVC_CS")
        {
                
        }
    }
}