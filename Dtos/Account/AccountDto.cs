using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Toverland_API_V2.Dtos.Account
{
    public class AccountDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public bool OneTimePassword { get; set; } = false;

        public AccountRole Role { get; set; } = AccountRole.GUEST;
    }
}