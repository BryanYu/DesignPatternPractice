using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Users
{
    internal class SqlserverUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("SQL Server新增資料");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("SQL Server查詢資料");
            return null;
        }
    }
}