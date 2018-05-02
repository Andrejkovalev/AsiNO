using System;
using System.Collections.Generic;
using System.Text;
using AsiNO_DAL.EF;
using AsiNO_DAL.Entities;
using AsiNO_DAL.Interfaces;

namespace AsiNO_DAL.Repositories
{
   public class ClientManager:IClientManager
    {
        public ApplicationContext Database { get; set; }

        public ClientManager(ApplicationContext db)
        {
            Database = db;
        }

        public void Create(ClientProfile item)
        {
            Database.ClientProfiles.Add(item);
            Database.SaveChanges();
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
