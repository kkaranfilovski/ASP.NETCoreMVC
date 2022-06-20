using SEDC.Class03.Demo.Models.Domain;

namespace SEDC.Class03.Demo
{
    public static class StaticDB
    {
        public static List<User> Users = new()
        {
            new User()
            {
                Id = 1,
                FirstName = "Kristijan",
                LastName = "Karanfilovski"
            },

            new User()
            {
                Id = 2,
                FirstName = "Ilija",
                LastName = "Mitev"
            },
            new User()
            {
                Id = 3,
                FirstName = "Martin",
                LastName = "Panovski"
            },
        };

        public static List<Order> Orders = new()
        {
            new Order()
            {
                Id= 1,
                DateCreated = DateTime.Now,
                User = Users.First(),
                isDelivered = true,
                Price = 320
            }
        };
    }
}
