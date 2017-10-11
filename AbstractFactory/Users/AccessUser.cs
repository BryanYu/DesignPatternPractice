using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Users
{
    internal class AccessUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("Access新增資料");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("Access查詢資料");
            return null;
        }
    }
}