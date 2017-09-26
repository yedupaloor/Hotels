using Hotels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;

namespace Hotels.ApiControllers
{
    public class HotelsController : ApiController
    {
        HotelContext db = new HotelContext();
        public IEnumerable<HotelVm> Get()
        {
            return db.Hotel.Select(h=> new HotelVm{ Id=h.Id, Name=h.Name, Address = h.Address }).ToList();
        }
        public Hotel GetHotels(int id)
        {
            var hotel = db.Hotel.FirstOrDefault(i => i.Id == id);
            var hotelDetails = db.HotelDetail.Where(d => d.Hotel.Id == id).ToList();
            hotel.HotelDetails = hotelDetails;
            return hotel;
        }

        [ResponseType(typeof(HotelVm))]
        public IHttpActionResult SaveHotel(Hotel hotel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Hotel.Add(hotel);
            db.SaveChanges();

            return CreatedAtRoute(
                "DefaultApi", 
                new { id = hotel.Id }, 
                new HotelVm {Id = hotel.Id, Name = hotel.Name, Address = hotel.Address });
        }

        public IEnumerable<HotelCommentVm> GetComments(int id)
        {
            var comments = db.Comment.Where(i => i.HotelId == id)
                .Select(c => new
                {
                    Name = c.Name,
                    Comment = c.Comment,
                    CreatedOn = c.CreatedOn
                })
                .OrderByDescending(c => c.CreatedOn)
                .ToList();
            List<HotelCommentVm> list = new List<HotelCommentVm>();
            foreach (var comment in comments)
            {
                list.Add(new HotelCommentVm
                {
                    Name = comment.Name,
                    Comment = comment.Comment,
                    CreatedOn = comment.CreatedOn.ToString("dd-MM-yy HH:mm")
                });
            }
            return list;
                
        }

        [ResponseType(typeof(HotelCommentVm))]
        public IHttpActionResult PostComment(HotelCommentVm comment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var hotelComment = new HotelComments
            {
                CreatedOn = DateTime.Now,
                Name = comment.Name,
                Email = comment.Email,
                Comment = comment.Comment,
                HotelId = comment.HotelId
            };
            db.Comment.Add(hotelComment);
            db.SaveChanges();

            return CreatedAtRoute(
                "DefaultApi",
                new { id = hotelComment.Id },
                new HotelCommentVm {
                    Name = hotelComment.Name,
                    Comment = hotelComment.Comment,
                    CreatedOn = hotelComment.CreatedOn.ToString("dd-MM-yy HH:mm") });
        }

    }

}
