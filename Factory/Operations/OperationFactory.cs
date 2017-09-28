using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Operations
{
    /// <summary>
    /// 運算類別工廠
    /// </summary>
    public class OperationFactory
    {
        /// <summary>
        /// 取得運算子執行個體
        /// </summary>
        /// <param name="operate">運算子</param>
        /// <returns><see cref="Operation"/></returns>
        public static Operation CreateOperate(string operate)
        {
            switch (operate)
            {
                case "+":
                    return new OperationAdd();

                case "-":
                    return new OperationSub();

                case "*":
                    return new OperationMul();

                case "/":
                    return new OperationMul();

                default:
                    throw new ArgumentException("參數錯誤");
            }
        }
    }
}