using System.ComponentModel.DataAnnotations;

namespace HotelReservation.Models.DB
{
    public class PaymentGatway
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "bankName")]
        [MaxLength(100, ErrorMessage = ErrorMessage.MaxLenghtMsg)]

        public string bankName { get; set; }

        [Display(Name = "PinCode")]
        [MaxLength(100, ErrorMessage = ErrorMessage.MaxLenghtMsg)]

        public string PinCode { get; set; }
    }
}
