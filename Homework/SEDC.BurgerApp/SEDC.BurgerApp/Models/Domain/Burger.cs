namespace SEDC.BurgerApp.Models.Domain
{
    public class Burger
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
        public bool HasFries { get; set; }

        public Burger(int id, string name, decimal price, bool isVege, bool isVegan, bool hasFries)
        {
            Id = id;
            Name = name;
            Price = price;
            IsVegetarian = isVege;
            IsVegan = isVegan;
            HasFries = hasFries;
        }
    }
}
