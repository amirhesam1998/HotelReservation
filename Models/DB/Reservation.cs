using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HotelReservation.Models.DB
{
    public class Reservation
    {
        [Key]
        public int id { get; set; }

        
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }

        [Display(Name = "Gender")]
        public int Gender { get; set; }


        [Display(Name = "first_name ")]
        [MaxLength(100, ErrorMessage = ErrorMessage.MaxLenghtMsg)]
        public string First_name { get; set; }


        [Display(Name = "Last_name ")]
        [MaxLength(100, ErrorMessage = ErrorMessage.MaxLenghtMsg)]
        public string Last_name { get; set; }


        [Display(Name = "NationalCode")]
        [MaxLength(10, ErrorMessage = ErrorMessage.MaxLenghtMsg)]
        public string NationalCode { get; set; }


        [Display(Name = "PhoneNumber ")]
        [MaxLength(11, ErrorMessage = ErrorMessage.MaxLenghtMsg)]
        public string PhoneNumber { get; set; }


        [Display(Name = "Email")]
        [MaxLength(100, ErrorMessage = ErrorMessage.MaxLenghtMsg)]
        public string Email { get; set; }


        [Display(Name = "Count_reservation")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequiredMsg)]
        public int CountReservation { get; set; }

        [Display(Name = "RoomCount")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequiredMsg)]
        public int RoomCount { get; set; }

        [Display(Name = "StartDate")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequiredMsg)]
        public DateTime StartDate { get; set; }

        [Display(Name = "EndDate")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequiredMsg)]
        public DateTime EndDate { get; set; }

        [Display(Name = "Amount")]
        public long Amount { get; set; }


        [Display(Name = "ReservationStatus")]
        public bool ReservationStatus { get; set; }

        [Display(Name = "DayCount")]
        public int DayCount { get; set; }

        [Display(Name = "ReservationIP")]
        [MaxLength(100, ErrorMessage = ErrorMessage.MaxLenghtMsg)]
        public string Rezerv_IP { get; set; }

        

        public Order Order { get; set; }
    }
}
