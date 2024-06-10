using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public enum AccountRole {
    GUEST,
    MANAGER,
    EMPLOYEE
}

namespace Toverland_API.Models
{
    public class Account
    {
        public int Id { get; set; }

        public string FirstName { get; private set; } = string.Empty;

        public string LastName { get; private set; } = string.Empty;

        public string Email { get; private set; } = string.Empty;

        public bool OneTimePassword { get; set; } = false;

        public string Password { get; set; } = string.Empty;

        public AccountRole Role { get; set; } = AccountRole.GUEST;

        public DateTime UpdatedAt { get; set; }

        

        public Account(int Id, string FirstName, string LastName, string Email)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
        }


        private void SetRole(AccountRole role) {

        }

        public void VerifyOTP(string OTP, string NewPassword) {

        }

        private void SetPassword(string password) {
            
        }
    }
}