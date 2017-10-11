using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Departments
{
    internal class SqlServerDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine("SQL Server 取得 Department");
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("SQL Server 新增 Department");
        }
    }
}