using SEDC.PizzaApp02.App.Models.Enums;

namespace SEDC.PizzaApp02.App.Models.ViewModels
{
    public class OrderDetailsViewModel
    {
        public string PizzaName { get; set; }
        public string UserName { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public double Price { get; set; }
        public bool Isdelivered { get; set; }
    }
}
