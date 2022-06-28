namespace SEDC.BurgerApp.Models.Domain
{
    public class Order
    {
        private static int IdCounter { get; set; } = 0;
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public bool IsDelivered { get; set; }
        public List<Burger> Burgers { get; set; }
        public string Location { get; set; }

        public Order()
        {

        }

        public Order(string fullName, string address, bool isDelivered, List<Burger> burgers, string location)
        {
            Id = IdCounter += 1;
            FullName = fullName;
            Address = address;
            IsDelivered = isDelivered;
            Burgers = burgers;
            Location = location;
        }
    }
}
