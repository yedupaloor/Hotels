namespace Hotels.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Hotels.HotelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Hotels.HotelContext context)
        {
            var marriots = new Hotel
            {
                Name = "Courtyard by Marriott Kochi Airport",
                Address = "Vip Rd, Opp Kochi International Airport | Vapalaserry, Nedumbassery, Kochi (Cochin) 683572, India",
                Description = "Experience 5-star accommodations at Courtyard by Marriott Kochi Airport, located just minutes from the airport. Through our modern amenities, our guests enjoy high-speed Internet access, attentive service and a surplus of modern conveniences. We are a preferred choice among hotels near Kochi airport, offering spacious rooms, refreshing suites, contemporary and vibrant dining options, comfortable luxury bedding, and functional work spaces with the perfect blend of comfort and flexibility for both business and leisure travelers. Outside of your comfortable living quarters is our state of the art health center and swimming pool provide rejuvenation after a long day of meetings. For groups looking for a venue for their next meetings, conventions and social events, our hotel has event space that is perfect for group of all sizes. Courtyard by Marriott Kochi Airport is the city's finest 5-star hotel in Kochi, Kerala, and is well-suited to both business and leisure travelers.",
                HotelDetails =
                    new List<HotelDetails>{
                                    new HotelDetails{ImageUrl = "http://cache.marriott.com/propertyimages/c/cokap/cokap_main01_r.jpg?resize=0.5x:0.5x"},
                                    new HotelDetails{ImageUrl = "https://c1.hiqcdn.com/customcdn/720x512/images/property/resortimg/718205_66082170607055441_org.jpg"}
                    }
            };
            var radisson = new Hotel
            {
                Name = "Radisson Blu Kochi",
                Address = "S.A. Road, Elamkulam Junction | Kadavanthara, Ernakulam, Kochi (Cochin) 682020",
                Description = "The contemporary hotel design and concept marries the drama of the exotic east with the whimsy of the west, offering travelers a new vision of modern luxury. A life-style hotel in the heart of Cochin city that is closest to the International Airport and with unmatched ease of access to the commercial hubs and heritage sites of Cochin. Spoil yourself at this hip and trendy hotel with a new vision of modern luxury and design. Strategically located in the heart of Cochin and 2 kms away from the Railway and Bus stations. In close proximity to the commercial hubs like MG Road, Infopark, Smart City and heritage sites of Cochin. Cochin Int'l Airport: 32 kms, 45 minutes.",
                HotelDetails =
                    new List<HotelDetails>{
                        new HotelDetails{ImageUrl = "https://www.cleartrip.com/places/hotels/2066/206634/images/Ava2_w.jpg"}
                    }
            };
            context.Hotel.AddOrUpdate(marriots);
            context.Hotel.AddOrUpdate(radisson);
        }
    }
}
