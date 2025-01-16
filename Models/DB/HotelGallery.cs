using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HotelReservation.Models.DB
{
    public class HotelGallery
    {
        [Key]
        public int id { get; set; }

        [Display(Name = " PictureName")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequiredMsg)]
        [MaxLength(100, ErrorMessage = ErrorMessage.MaxLenghtMsg)]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequiredMsg)]
        [Display(Name = " MainPicture")]
        public bool Main_picture { get; set; }


        public int HotelId { get; set; }

        public Hotel Hotel { get; set; }
    }
}
