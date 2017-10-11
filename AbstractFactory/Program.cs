using AbstractFactory.Departments;
using AbstractFactory.Factory;
using AbstractFactory.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var user = new User();
            IFactory factory = new SqlServerFactory();
            var userFactory = factory.CreateUser();
            userFactory.Insert(user);
            userFactory.GetUser(1);

            var department = new Department();
            var departmentFactory = factory.CreateDepartment();
            departmentFactory.Insert(department);
            departmentFactory.GetDepartment(1);

            Console.Read();
        }
    }
}