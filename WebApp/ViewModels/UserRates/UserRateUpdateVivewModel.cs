using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels.UserRates
{
    public class UserRateUpdateVivewModel
    {
        [Required]
        public int Id { get; set; }
        [StringLength(100, ErrorMessage = "Max 100 character.")]
        public string Comment { get; set; }
    }
}