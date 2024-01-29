using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels.Rates
{
    public class SaveRateViewModel
    {
        [Required]
        public string Unit { get; set; }
        [Required]
        public string Currency { get; set; }
        [Required]
        public string CurrentRate { get; set; }
        [StringLength(100, ErrorMessage = "Max 100 character.")]
        public string Comment { get; set; }
    }
}