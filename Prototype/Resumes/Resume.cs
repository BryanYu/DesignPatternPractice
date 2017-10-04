using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Resumes
{
    internal class Resume : ICloneable
    {
        private string _name;

        private string _sex;

        private string _age;

        private WorkExperience _workExperience;

        public Resume(string name)
        {
            this._name = name;
            this._workExperience = new WorkExperience();
        }

        public Resume(WorkExperience workExperience)
        {
            this._workExperience = (WorkExperience)workExperience.Clone();
        }

        public void SetPersonalInfo(string sex, string age)
        {
            this._sex = sex;
            this._age = age;
        }

        public void SetWorkExperience(string workDate, string company)
        {
            this._workExperience.WorkDate = workDate;
            this._workExperience.Company = company;
        }

        public void Display()
        {
            Console.WriteLine("{0} {1} {2}", this._name, this._sex, this._age);
            Console.WriteLine("工作經歷：{0} {1}", this._workExperience.WorkDate, this._workExperience.Company);
        }

        public object Clone()
        {
            var obj = new Resume(this._workExperience);
            obj._name = this._name;
            obj._age = this._age;
            obj._sex = this._sex;
            return obj;
        }
    }
}