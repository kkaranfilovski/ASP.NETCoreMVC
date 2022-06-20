using SEDC.BurgerApp.Models.Domain;

namespace SEDC.BurgerApp
{
    public static class StaticDB
    {
        public static List<Burger> Burgers { get; set; } = new()
        {
            new Burger("Hamburger", 150, false, false, true),
            new Burger("Cheeseburger", 180, false, false, true),
            new Burger("Vegeburger", 140, true, false, true),
            new Burger("Veggieburger", 200, true, true, false)
        };

        public static List<Order> Orders { get; set; } = new()
        {
            new Order("Kristijan Karanfilovski", "ul. France Preshern br.46", false, new List<Burger>() { Burgers[0], Burgers[1] }, "Vlae"),
            new Order("Ilija Mitev", "ul. Radisani Hills br.99", false, new List<Burger>() { Burgers[1] }, "Radisani"),
            new Order("Aneta Stankovska", "ul. Sparkling Water br. 10", false, new List<Burger>() { Burgers[2], Burgers[3] }, "Kisela Voda")
        };
    }
}
