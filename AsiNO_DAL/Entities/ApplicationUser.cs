using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNet.Identity.EntityFramework;


namespace AsiNO_DAL.Entities
{
   public   class ApplicationUser: IdentityUser
    {
        public virtual ClientProfile ClientProfile { get; set; }
    }
}
