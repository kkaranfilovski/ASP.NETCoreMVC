﻿using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Helpers
{
    public static class UserMapper
    {
        public static UserSelectViewModel MapToUserSelectViewModel(this User user)
        {
            return new UserSelectViewModel
            {
                Id = user.Id,
                FullName = $"{user.FirstName} {user.FirstName}"
            };
        }
    }
}
