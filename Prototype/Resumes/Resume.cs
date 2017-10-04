using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Resumes
{
    internal class Resume
    {
        private string _name;

        private string _sex;

        private string _age;

        private string _timeArea;

        private string _company;

        public Resume(string name)
        {
            this._name = name;
        }

        public void SetPersonalInfo(string sex, string age)
        {
            this._sex = sex;
            this._age = age;
        }

        public void SetWorkExperience(string timeArea, string company)
        {
            this._timeArea = timeArea;
            this._company = company;
        }

        public void Display()
        {
            Console.WriteLine("{0} {1} {2}", this._name, this._sex, this._age);
            Console.WriteLine("工作經歷：{0} {1}", this._timeArea, this._company);
        }
    }
}