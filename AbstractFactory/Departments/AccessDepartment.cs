using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Departments
{
    internal class AccessDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine("Access 取得 Department");
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("Access 新增 Department");
        }
    }
}