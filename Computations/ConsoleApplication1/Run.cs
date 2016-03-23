using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Run
    {
        public void start()
        {
            // GameLogic.MushroomColor
            Dictionary<int, Double> dictt = new Dictionary<int, double>();

            dictt.Add(1, 10.10);
            dictt.Add(2, 20.20);
            dictt.Add(3, 33.33);

            foreach (KeyValuePair<int, Double> pair in dictt)
            {
                Console.WriteLine("{0} :: {1}", pair.Key, pair.Value);
            }

            Console.WriteLine("Press Enter to Finnish!");
            Console.ReadLine();

            doStrategy();

            Console.WriteLine("Press Enter to Finnish!");
            Console.ReadLine();

        }



        public void doStrategy()
        {
            Context context;

            context = new Context(new Cosine());
            context.computeStrategy(5, 5);

            context = new Context(new Pearson());
            context.computeStrategy(5, 5);

            context = new Context(new Euclidian());
            context.computeStrategy(5, 5);
;        }
    }
}
