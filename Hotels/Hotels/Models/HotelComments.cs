using System;
using System.ComponentModel.DataAnnotations;

namespace Hotels
{
    public class HotelComments
    {
        [Key]
        public int Id { get; set; }

        [DataType("varchar")]
        [MaxLength(100)]
        [Required]
        public string Name { get; set; }

        [DataType("varchar")]
        [MaxLength(100)]
        [Required]
        public string Email { get; set; }

        [DataType("varchar")]
        [MaxLength(2000)]
        public string Comment { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedOn { get; set; }

        public virtual int HotelId { get; set; }

        public virtual Hotel Hotel { get; set; }


    }
}