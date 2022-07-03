using System.ComponentModel.DataAnnotations;

namespace SEDC.BurgerApp.Models.ViewModels
{
    public class EditViewModel
    {
        [Display(Name = "Full name")]
        [Required(ErrorMessage = "Please enter your name")]
        public string UserFullName { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter your location")]
        public string Location { get; set; }

        [Display(Name = "Burgers")]
        [Required(ErrorMessage = "Please select burgers")]
        public List<int> BurgerId { get; set; }

        [Display(Name = "Status")]
        public bool IsDelivered { get; set; }
    }
}
