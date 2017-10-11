using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Departments
{
    internal interface IDepartment
    {
        void Insert(Department department);

        Department GetDepartment(int id);
    }
}