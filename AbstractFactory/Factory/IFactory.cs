using AbstractFactory.Departments;
using AbstractFactory.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    internal interface IFactory
    {
        IUser CreateUser();

        IDepartment CreateDepartment();
    }
}