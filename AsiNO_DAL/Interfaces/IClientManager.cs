using System;
using System.Collections.Generic;
using System.Text;
using AsiNO_DAL.Entities;

namespace AsiNO_DAL.Interfaces
{
    public interface IClientManager : IDisposable
    {
        void Create(ClientProfile item);
    }
}
