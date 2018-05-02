using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using AsiNO_DAL.Entities;


namespace AsiNO_DAL.EF
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext(string conectionString) : base(conectionString) { }

        public DbSet<ClientProfile> ClientProfiles { get; set; }
    }
}
