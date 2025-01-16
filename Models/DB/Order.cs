using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HotelReservation.Models.DB
{
    public class Order
    {
        [Key]
        public int id { get; set; }

        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }

        [Display(Name = "DatePayment")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequiredMsg)]
        public DateTime DatePayment { get; set; }

        [MaxLength(30, ErrorMessage = ErrorMessage.MaxLenghtMsg)]
        [Display(Name = "Tracking_code")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequiredMsg)]
        public string TrackingCode { get; set; }

        [Display(Name = "Amount")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequiredMsg)]
        public long amount { get; set; }

        [Display(Name = "StatusPayment")]
        public bool StatusPayment { get; set; }

        [MaxLength(50, ErrorMessage = ErrorMessage.MaxLenghtMsg)]
        [Display(Name = "TransactionNumber")]
        public string TransactionNumber { get; set; }

        [MaxLength(50, ErrorMessage = ErrorMessage.MaxLenghtMsg)]
        [Display(Name = "BankRefrenceNumber")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequiredMsg)]
        public string BankRefrenceNumber { get; set; }

        [Display(Name = "ReservationNumber")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequiredMsg)]
        public int ReservationNumber { get; set; }


        public int ResevationId { get; set; }
        public Reservation Reservation { get; set; }

        
    }
}
