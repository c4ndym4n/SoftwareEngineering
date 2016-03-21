using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEng
{
    class Run
    {
        static void Main(string[] args)
        {
            // Here starts everything
            
            // Read in File
            foreach (string line in File.ReadLines(@"C:\Users\Nimbus\Documents\test.txt"))
            {
                if (line.Contains("INSTALL NOTES:"))
                {
                    Console.WriteLine("unpacking");
                }
                Console.WriteLine(line);
            }




            Console.WriteLine("Press Enter to Close");
            Console.ReadLine();
            // F# Methods
            
            // Strategy Pattern

        }
    }
}
