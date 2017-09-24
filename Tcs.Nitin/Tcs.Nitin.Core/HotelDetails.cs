using System.ComponentModel.DataAnnotations;

namespace Tcs.Nitin.Core
{
    public class HotelDetails
    {
        [Key]
        public int Id { get; set; }

        [DataType("varchar")]
        [MaxLength(1000)]
        public string ImageUrl { get; set; }

        public virtual Hotel Hotel { get; set; }

    }
}
