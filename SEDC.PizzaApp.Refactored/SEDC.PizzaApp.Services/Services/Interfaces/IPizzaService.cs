using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.ViewModels.PizzaViewModels;

namespace SEDC.PizzaApp.Services.Services.Interfaces
{
    public interface IPizzaService
    {
        List<PizzaViewModel> GetPizzasOnPromotion();
    }
}
