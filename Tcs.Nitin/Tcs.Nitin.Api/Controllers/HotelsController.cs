using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Tcs.Nitin.Core;

namespace Tcs.Nitin.Api.Controllers
{
    public class HotelsController : ApiController
    {
        HotelContext db = new HotelContext();
        public IEnumerable<HotelVm> Get()
        {
            return db.Hotel.Select(h=> new HotelVm{ Id=h.Id, Name=h.Name, Address = h.Address }).ToList();
        }
        public Hotel Get(int id)
        {
            var hotel = db.Hotel.FirstOrDefault(i => i.Id == id);
            var hotelDetails = db.HotelDetails.Where(d => d.Hotel.Id == id).ToList();
            hotel.HotelDetails = hotelDetails;
            return hotel;
        }
    }

}
