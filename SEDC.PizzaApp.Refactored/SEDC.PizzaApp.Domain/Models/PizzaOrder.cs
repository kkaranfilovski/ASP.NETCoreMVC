namespace SEDC.PizzaApp.Domain.Models
{
    public class PizzaOrder : BaseEntity
    {
        public int PizzaId { get; set; }
        public Pizza Pizza { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
