namespace SEDC.BurgerApp.Models.Domain
{
    public class Burger
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public bool IsVegetarian { get; set; }
        public bool IsVegan { get; set; }
        public bool HasFries { get; set; }

        public Burger(string name, int price, bool isVege, bool isVegan, bool hasFries)
        {
            Name = name;
            Price = price;
            IsVegetarian = isVege;
            IsVegan = isVegan;
            HasFries = hasFries;
        }
    }
}
