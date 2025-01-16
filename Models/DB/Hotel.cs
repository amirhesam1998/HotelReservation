using System.ComponentModel.DataAnnotations;

namespace HotelReservation.Models.DB
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Hotel_Name")]
        [Required(ErrorMessage = ErrorMessage.RequiredMsg)]
        public string Name { get; set; }


        [Display(Name = "Hotel_Address")]
        [Required(ErrorMessage = ErrorMessage.RequiredMsg)]
        public string Address { get; set; }



        [Display(Name = "Hotel_Price")]
        [Required(ErrorMessage = ErrorMessage.RequiredMsg)]
        public long Price { get; set; }


        [Display(Name = "Hotel_Start_Date")]
        [DataType(DataType.Date)]
        public DateTime Start_Date { get; set; }


        [Display(Name = "Hotel_End_Date")]
        [DataType(DataType.Date)]
        public DateTime End_Date { get; set; }



        [Display(Name = "Status")]
        public bool Status { get; set; } = false;


        [Display(Name = "Hotel_Description")]
        [DataType(DataType.Text)]
        public string? Description { get; set; }


        public ICollection<HotelInfo> HotelInfos { get; set; }
        
        public ICollection<HotelGallery> HotelGalleries { get; set; }

        public ICollection<HotelComment> HotelComments { get; set; }

        public ICollection<HotelFacility> HotelFacilities { get; set; }

        public ICollection<Reservation> Reservations { get; set; }

        public ICollection<Order> Orders { get; set; }


    }


}
