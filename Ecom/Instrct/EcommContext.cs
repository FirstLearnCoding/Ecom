using Ecom.Ppty;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom.Instrct
{
    public class EcommContext : DbContext
    {
        public EcommContext(DbContextOptions<EcommContext> opt) : base(opt)
        {

        }
        public DbSet<Ecomm> EcomPro { get; set; }
        public DbSet<Profiles> ProfileData { get; set; }
        public DbSet<ProductWishlist> WishData { get; set; }
        public DbSet<ProductPurchase> PurchaseData { get; set; }
    }
}
