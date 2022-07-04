using SEDC.PizzaApp.Domain.Models;

namespace SEDC.PizzaApp.DataAccess.Repositories.Interfaces
{
    public interface IPizzaRepository : IRepository<Pizza>
    {
        List<Pizza> GetOnPromotion();
    }
}
