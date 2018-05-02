using AsiNO_BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using AsiNO_DAL.Repositories;

namespace AsiNO_BLL.Services
{
    public class ServiceCreator : IServiceCreator
    {
        public IUserService CreateUserService(string connection)
        {
            return new UserService(new IdentityUnitOfWork(connection));
        }
    }
}
