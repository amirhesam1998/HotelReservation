using System.ComponentModel.DataAnnotations;

namespace HotelReservation.Models.DB
{
    public class HotelComment
    {
        [Key]
        public int Id { get; set; }

        public string Author { get; set; }


        public string Text { get; set; }

        public DateTime Date { get; set; }

        public string Email { get; set; }

        public float Rate { get; set; }


        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
    }
}
