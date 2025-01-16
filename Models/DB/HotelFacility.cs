using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HotelReservation.Models.DB
{
    public class HotelFacility
    {
        [Key]
        public int id { get; set; }


        [Display(Name = "title")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequiredMsg)]
        [MaxLength(100, ErrorMessage = ErrorMessage.MaxLenghtMsg)]
        public string title { get; set; }

        [Display(Name = "Icon")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequiredMsg)]
        [MaxLength(100, ErrorMessage = ErrorMessage.MaxLenghtMsg)]
        public string Icon { get; set; }

        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
    }
}
