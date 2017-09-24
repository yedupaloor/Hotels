using System.Data.Entity;

namespace Tcs.Nitin.Core
{
    public class HotelContext : DbContext
    {
        public HotelContext():base("hotels")
        {
        }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<HotelDetails> HotelDetails { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
