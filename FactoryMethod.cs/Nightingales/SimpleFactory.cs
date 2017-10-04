using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Nightingales
{
    internal class SimpleFactory
    {
        public static Nightingle CreateNightingle(RoleType type)
        {
            switch (type)
            {
                case RoleType.Student:
                    return new Undergraduate();

                case RoleType.Volunteer:
                    return new Volunteer();

                default:
                    throw new ArgumentException("參數錯誤");
            }
        }
    }
}