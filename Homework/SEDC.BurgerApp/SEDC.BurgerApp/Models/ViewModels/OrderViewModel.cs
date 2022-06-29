using System.ComponentModel.DataAnnotations;

namespace SEDC.BurgerApp.Models.ViewModels
{
    public class OrderViewModel
    {
        [Display(Name = "Full name")]
        [Required(ErrorMessage = "Please enter your name")]
        public string UserFullName { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        public string Adress { get; set; }

        [Required(ErrorMessage = "Please enter your location")]
        public string Location { get; set; }

        [Display(Name = "Burgers")]
        [Required(ErrorMessage = "Please select burger")]
        public List<int> BurgerId { get; set; } 
    }
}
