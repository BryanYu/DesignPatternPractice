using AbstractFactory.DataAccesses;
using AbstractFactory.Departments;
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

            var userFactory = DataAccess.GetUser();
            userFactory.Insert(user);
            userFactory.GetUser(1);

            var department = new Department();
            var departmentFactory = DataAccess.GetDepartment();
            departmentFactory.Insert(department);
            departmentFactory.GetDepartment(1);

            Console.Read();
        }
    }
}