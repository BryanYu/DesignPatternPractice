using AbstractFactory.Departments;
using AbstractFactory.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.DataAccesses
{
    internal class DataAccess
    {
        private static readonly string db = "SqlServer";

        //private static readonly string db = "Access";

        public static IUser GetUser()
        {
            IUser result = null;
            switch (db)
            {
                case "SqlServer":
                    result = new SqlserverUser();
                    break;

                case "Access":
                    result = new AccessUser();
                    break;
            }
            return result;
        }

        public static IDepartment GetDepartment()
        {
            IDepartment result = null;
            switch (db)
            {
                case "SqlServer":
                    result = new SqlServerDepartment();
                    break;

                case "Access":
                    result = new AccessDepartment();
                    break;
            }
            return result;
        }
    }
}