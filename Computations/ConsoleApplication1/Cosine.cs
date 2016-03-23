using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Cosine : StrategyInterface
    {
        public int compute(int num1, int num2)
        {
            // throw new NotImplementedException();
            Console.WriteLine(num1 * num2);
            return num1 * num2;
        }

    }
}
