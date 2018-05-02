using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNet.Identity;
using AsiNO_DAL.Entities;

namespace AsiNO_DAL.Identity
{
    public class ApplicationUserManager: UserManager<ApplicationUser>
    {
        public ApplicationUserManager(IUserStore<ApplicationUser> store)
            : base(store)
        {
        }
    }
}
