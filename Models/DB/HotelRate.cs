using System.ComponentModel.DataAnnotations;

namespace HotelReservation.Models.DB
{
    public class HotelRate
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Rate")]
        [Range(1, int.MaxValue, ErrorMessage = ErrorMessage.Range)]
        public int count { get; set; }

        public ICollection<HotelInfo> Rates { get; set; }

    }
}
