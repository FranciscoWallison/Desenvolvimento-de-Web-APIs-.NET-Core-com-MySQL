using System;

namespace YouLearn.Domain.Arguments.User
{
    public class AddUserResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
    
}