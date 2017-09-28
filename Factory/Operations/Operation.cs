using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Operations
{
    /// <summary>
    /// 計算類別
    /// </summary>
    public class Operation
    {
        private double _numberA = 0;

        private double _numberB = 0;

        public double NumberA
        {
            get { return this._numberA; }
            set { _numberA = value; }
        }

        public double NumberB
        {
            get { return this._numberB; }
            set { _numberB = value; }
        }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }

        public static double GetResult(double numberA, double numberB, string operate)
        {
            double result = 0d;
            switch (operate)
            {
                case "+":
                    result = numberA + numberB;
                    break;

                case "-":
                    result = numberA - numberB;
                    break;

                case "*":
                    result = numberA * numberB;
                    break;

                case "/":
                    result = numberA / numberB;
                    break;
            }
            return result;
        }
    }
}