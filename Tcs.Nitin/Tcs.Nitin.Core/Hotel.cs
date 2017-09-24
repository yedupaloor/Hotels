using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tcs.Nitin.Core
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }

        [DataType("varchar")]
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }

        [DataType("varchar")]
        [MaxLength(2000)]
        public string Address { get; set; }

        [DataType("varchar")]
        [MaxLength(2000)]
        public string Description { get; set; }

        public virtual ICollection<HotelDetails> HotelDetails { get; set; }
    }
}
