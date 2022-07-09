using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.ViewModels.UserViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Mappers.Extensions
{
    public static class UserMapper
    {
        public static UserViewModel MapToUserViewModel(this User user)
        {
            return new UserViewModel
            {
                Id = user.Id,
                FullName = $"{user.FirstName} {user.LastName}"
            };
        }
    }
}
