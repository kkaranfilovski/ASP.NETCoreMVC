using SEDC.BurgerApp.Models.Domain;
using SEDC.BurgerApp.Models.ViewModels;

namespace SEDC.BurgerApp.Helpers
{
    public static class OrderMapper
    {
        public static OrderListViewModel MapToOrderListViewModel(this Order order)
        {
            decimal price = 0;
            foreach(var burger in order.Burgers)
            {
                price += burger.Price;
            }

            return new OrderListViewModel
            {
                OrderId = order.Id,
                UserFullName = order.FullName,
                TotalPrice = price           
            };
        }

        public static OrderDetailsViewModel MapToOrderDetailsViewModel(this Order order)
        {
            decimal price = 0;
            var name = new List<string>();
            foreach (var burger in order.Burgers)
            {
                name.Add(burger.Name);
                price += burger.Price;
            }

            return new OrderDetailsViewModel
            {   
                OrderId = order.Id,
                UserFullName = order.FullName,
                TotalPrice = price,
                Address = order.Address,
                Burgers = name,
                status = order.IsDelivered
            };
        }

        public static OrderViewModel MapToOrderViewModel(this Order order)
        {
            return new OrderViewModel
            {
                UserFullName = order.FullName,
                Adress = order.Address,
                Location = order.Location
            };
        }

        public static Order MapToOrder(this OrderViewModel orderViewModel)
        {
            var burgersFromDb = new List<Burger>();
            foreach(var id in orderViewModel.BurgerId)
            {
                var burger = StaticDB.Burgers.FirstOrDefault(x => x.Id == id);
                burgersFromDb.Add(burger);
            }

            var orderId = StaticDB.Orders.Count + 1;

            var order = new Order(orderId, orderViewModel.UserFullName, orderViewModel.Adress, false, burgersFromDb, orderViewModel.Location);
            return order;
        }

        public static Order MapToOrder(this OrderViewModel orderViewModel, int orderId)
        {
            var burgersFromDb = new List<Burger>();
            foreach (var id in orderViewModel.BurgerId)
            {
                var burger = StaticDB.Burgers.FirstOrDefault(x => x.Id == id);
                burgersFromDb.Add(burger);
            }

            var order = new Order(orderId, orderViewModel.UserFullName, orderViewModel.Adress, false, burgersFromDb, orderViewModel.Location);
            return order;
        }
    }
}
