using SEDC.BurgerApp.Models.Domain;
using SEDC.BurgerApp.Models.ViewModels;

namespace SEDC.BurgerApp.Helpers
{
    public static class BurgerMapper
    {
        public static BurgerSelectViewModel MapToBurgerSelectViewModel (this Burger burger)
        {
            return new BurgerSelectViewModel
            {
                Id = burger.Id,
                Name = burger.Name,
            };
        }
    }
}
