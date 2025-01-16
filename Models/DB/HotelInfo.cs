using System.ComponentModel.DataAnnotations;

namespace HotelReservation.Models.DB
{
    public class HotelInfo
    {
        [Key]
        public int Id { get; set; }


        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }


        public int RoomId { get; set; }
        public Room Room { get; set; }

        public int BedId { get; set; }
        public Bed Bed { get; set; }

        public int RateId { get; set; }
        public HotelRate HotelRate { get; set; }

        [Required]
        [Range(0, int.MaxValue , ErrorMessage = ErrorMessage.Range)]
        public int stock { get; set; }


        public int ProvinceId { get; set; }
        public Province Province { get; set; }
    }
}
