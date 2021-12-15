using System;
using System.Collections.Generic;
using System.Linq;
using meet_up_3.ViewModels.User;
using meet_up_4_git.Data;
using meet_up_4_git.Models;
using meet_up_4_git.ViewModels.User;
using Microsoft.EntityFrameworkCore;

namespace meet_up_4_git.Services
{
    public class UsersService : IUserService
    {
        private readonly Context _context;

        public UsersService(Context context)
        {
            _context = context;
        }

        public IEnumerable<User> GetUsers() => _context.Users.AsNoTracking().AsEnumerable();
        
        public User GetUser(Guid id) => _context.Users.AsNoTracking().FirstOrDefault(x => x.Id == id);

        public void AddUser(User user) {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        
        public void UpdateUser(UpdateUserViewModel user)
        {
            var existingUser = _context.Users.FirstOrDefault(x => x.Id == user.Id);

            if (existingUser is null)
                throw new Exception("User not found");

            existingUser.Email = user.Email;
            existingUser.Password = user.Password;
            existingUser.FirstName = user.FirstName;
            existingUser.LastName = user.LastName;

            _context.Users.Update(existingUser);
            _context.SaveChanges();
        }

        public void DeleteUser(Guid id)
        {
            var user = _context.Users.FirstOrDefault(x => x.Id == id);

            if (user is null)
                throw new Exception("User not found");

            try
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("User couldn't be deleted");
            }
        }

        public void DeleteUser(User user)
        {
            try
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
            catch (Exception )
            {
                throw new Exception("User couldn't be deleted");
            }
        }
    }
}