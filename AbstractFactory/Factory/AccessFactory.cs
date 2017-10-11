using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Users;

namespace AbstractFactory.Factory
{
    internal class AccessFactory : IFactory
    {
        public IUser CreateUser()
        {
            return new AccessUser();
        }
    }
}