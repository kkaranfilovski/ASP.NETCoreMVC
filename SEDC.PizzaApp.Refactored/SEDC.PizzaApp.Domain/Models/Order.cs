using SEDC.PizzaApp.Domain.Enums;

namespace SEDC.PizzaApp.Domain.Models
{
    public class Order : BaseEntity
    {
        public bool IsDelivered { get; set; }
        public string Location { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public List<PizzaOrder> PizzaOrders { get; set; }
    }
}
