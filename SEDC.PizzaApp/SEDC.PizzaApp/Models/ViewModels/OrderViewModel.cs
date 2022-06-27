using SEDC.PizzaApp.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace SEDC.PizzaApp.Models.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Pizza Name")]
        [Required(ErrorMessage = "Please enter pizza name..")]
        public string PizzaName { get; set; }

        [Required(ErrorMessage = "Please select payment method..")]

        public PaymentMethod PaymentMethod { get; set; }

        [Required(ErrorMessage = "Please select user..")]

        public int UserId { get; set; }
    }
}
