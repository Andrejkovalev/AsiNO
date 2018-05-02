using System;
using System.Collections.Generic;
using System.Text;

namespace AsiNO_BLL.Interfaces
{
    public interface IServiceCreator
    {
        IUserService CreateUserService(string connection);
    }
}
