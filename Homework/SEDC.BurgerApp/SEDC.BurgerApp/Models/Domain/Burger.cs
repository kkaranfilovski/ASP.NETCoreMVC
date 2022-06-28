namespace SEDC.BurgerApp.Models.Domain
{
    public class Burger
    {
        private static int IdCounter { get; set; } = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
        public bool HasFries { get; set; }

        public Burger(string name, decimal price, bool isVege, bool isVegan, bool hasFries)
        {
            Id = IdCounter += 1;
            Name = name;
            Price = price;
            IsVegetarian = isVege;
            IsVegan = isVegan;
            HasFries = hasFries;
        }
    }
}
