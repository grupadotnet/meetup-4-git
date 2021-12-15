using System;
using System.Collections.Generic;
using meet_up_3.ViewModels.User;
using meet_up_4_git.Models;
using meet_up_4_git.ViewModels.User;

namespace meet_up_4_git.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        
        User GetUser(Guid id);
        
        void AddUser(User user);

        void UpdateUser(UpdateUserViewModel user);

        void DeleteUser(Guid id);
        
        void DeleteUser(User user);
    }
}