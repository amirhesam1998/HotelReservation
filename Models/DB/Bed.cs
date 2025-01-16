using System.ComponentModel.DataAnnotations;

namespace HotelReservation.Models.DB
{
    public class Bed
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Bed_Count")]
        [Range(1, int.MaxValue, ErrorMessage = ErrorMessage.Range)]
        public int count { get; set; }

        public ICollection<HotelInfo> Beds { get; set; }

    }
}
