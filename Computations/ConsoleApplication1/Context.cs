using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Context
    {
        private StrategyInterface strategy;

        public Context(StrategyInterface strategy)
        {
            this.strategy = strategy;
        }

        public void computeStrategy(int a, int b)
        {
            strategy.compute(a, b);
        }

    }
}
