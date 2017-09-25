using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Hotels;

namespace Hotels.Controllers
{
    public class HotelDetailsController : ApiController
    {
        private HotelContext db = new HotelContext();

        // GET: api/HotelDetails
        public IQueryable<HotelDetails> GetHotelDetail()
        {
            return db.HotelDetail;
        }

        // GET: api/HotelDetails/5
        [ResponseType(typeof(HotelDetails))]
        public IHttpActionResult GetHotelDetails(int id)
        {
            HotelDetails hotelDetails = db.HotelDetail.Find(id);
            if (hotelDetails == null)
            {
                return NotFound();
            }

            return Ok(hotelDetails);
        }

        // PUT: api/HotelDetails/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHotelDetails(int id, HotelDetails hotelDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hotelDetails.Id)
            {
                return BadRequest();
            }

            db.Entry(hotelDetails).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotelDetailsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/HotelDetails
        [ResponseType(typeof(HotelDetails))]
        public IHttpActionResult PostHotelDetails(HotelDetails hotelDetails)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.HotelDetail.Add(hotelDetails);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = hotelDetails.Id }, hotelDetails);
        }

        // DELETE: api/HotelDetails/5
        [ResponseType(typeof(HotelDetails))]
        public IHttpActionResult DeleteHotelDetails(int id)
        {
            HotelDetails hotelDetails = db.HotelDetail.Find(id);
            if (hotelDetails == null)
            {
                return NotFound();
            }

            db.HotelDetail.Remove(hotelDetails);
            db.SaveChanges();

            return Ok(hotelDetails);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HotelDetailsExists(int id)
        {
            return db.HotelDetail.Count(e => e.Id == id) > 0;
        }
    }
}