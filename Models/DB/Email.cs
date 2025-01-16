using System.ComponentModel.DataAnnotations;
//using HotelReservation.Models.Validations;

namespace HotelReservation.Models.DB
{
    public class Email
    {
        [Key]
        public int Id { get; set; }


        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        //[UniqueField("Email","Email_Send")]
        public string Email_Send { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string Email_Password { get; set; }



        [Required]
        [Display(Name = "UserName")]
        public string Email_Username { get; set; }


        [Required]
        [Display(Name = "Port")]
        public string Email_Port { get; set; }


        [Required]
        [Display(Name = "Smtp")]
        public string Email_Smtp { get; set; }

    }
}
