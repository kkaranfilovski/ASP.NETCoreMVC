using SEDC.PizzaApp.Models.Enums;

namespace SEDC.PizzaApp.Models.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public Pizza Pizza { get; set; }
        public User User { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public bool IsDelivered { get; set; }
    }
}
