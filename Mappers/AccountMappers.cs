using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Toverland_API.Models;
using Toverland_API_V2.Dtos.Account;

namespace Toverland_API_V2.Mappers
{
    public static class AccountMappers
    {
    public static AccountDto ToAccountDto(this Account account)
        {
            return new AccountDto
            {
                Id = account.Id,
                FirstName = account.FirstName,
                LastName = account.LastName,
                Email = account.Email,
                OneTimePassword = account.OneTimePassword,
                Role = account.Role
            };
        }
    }

}