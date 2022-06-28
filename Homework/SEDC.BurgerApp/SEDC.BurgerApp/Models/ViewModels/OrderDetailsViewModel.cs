namespace SEDC.BurgerApp.Models.ViewModels
{
    public class OrderDetailsViewModel
    {
        public int OrderId { get; set; }
        public string UserFullName { get; set; }
        public decimal TotalPrice { get; set; }
        public string Address { get; set; }
        public bool status { get; set; }
        public List<string> Burgers { get; set; }
    }
}
