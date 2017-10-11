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
            var sqlserverUser = new SqlserverUser();
            sqlserverUser.Insert(user);
            sqlserverUser.GetUser(1);

            Console.Read();
        }
    }
}