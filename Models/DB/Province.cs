using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace HotelReservation.Models.DB
{
    public class Province
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "province")]
        [Required(AllowEmptyStrings = false, ErrorMessage = ErrorMessage.RequiredMsg)]
        [MaxLength(100, ErrorMessage = ErrorMessage.MaxLenghtMsg)]
        public string Name { get; set; }


        public virtual ICollection<HotelInfo> Provinces { get; set; }
    }
}
