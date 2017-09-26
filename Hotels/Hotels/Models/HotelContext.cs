using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Hotels
{
    public class HotelContext : DbContext
    {
        public HotelContext() :base("hotelConnectionString")
        {

        }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<HotelDetails> HotelDetail { get; set; }
        public DbSet<HotelComments> Comment { get; set; }
    }
}