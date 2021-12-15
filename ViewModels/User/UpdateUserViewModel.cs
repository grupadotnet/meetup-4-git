using System;

namespace meet_up_3.ViewModels.User
{
    public class UpdateUserViewModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string Password { get; set; }
        
        public string Email { get; set; }
    }
}