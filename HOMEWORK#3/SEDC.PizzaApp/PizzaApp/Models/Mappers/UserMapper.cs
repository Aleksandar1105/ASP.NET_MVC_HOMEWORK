using PizzaApp.Models.Domain;
using PizzaApp.Models.ViewModels.UserViewModel;

namespace PizzaApp.Models.Mappers
{
    public static class UserMapper
    {
        public static UserListViewModel MapFromUserToUserListViewModel(this User user)
        {
            return new UserListViewModel()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName
            };
        }
    }
}
