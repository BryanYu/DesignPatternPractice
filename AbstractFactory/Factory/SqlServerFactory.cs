using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Departments;
using AbstractFactory.Users;

namespace AbstractFactory.Factory
{
    internal class SqlServerFactory : IFactory
    {
        public IDepartment CreateDepartment()
        {
            return new SqlServerDepartment();
        }

        public IUser CreateUser()
        {
            return new SqlserverUser();
        }
    }
}