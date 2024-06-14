using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


public enum UserRole {
    GUEST,
    MANAGER,
    EMPLOYEE
}

namespace Toverland_API.Models
{
    public class Account : IdentityUser
    {

    
        
        private void SetRole(UserRole role) {

        }

        public void VerifyOTP(string OTP, string NewPassword) {

        }

        private void SetPassword(string password) {
            
        }
    }
}