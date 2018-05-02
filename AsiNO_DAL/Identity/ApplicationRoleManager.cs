using System;
using System.Collections.Generic;
using System.Text;
using AsiNO_DAL.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;


namespace AsiNO_DAL.Identity
{
   public  class ApplicationRoleManager : RoleManager<ApplicationRole>
   {
       public ApplicationRoleManager(RoleStore<ApplicationRole> store)
           : base(store)
       { }
   }
   
}
