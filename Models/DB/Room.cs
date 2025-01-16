using System.ComponentModel.DataAnnotations;

namespace HotelReservation.Models.DB
{
    public class Room
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Room_Count")]
        [Range(1, int.MaxValue, ErrorMessage = ErrorMessage.Range)]
        public int count { get; set; }


        public ICollection<HotelInfo> Rooms { get; set; }

    }
}
