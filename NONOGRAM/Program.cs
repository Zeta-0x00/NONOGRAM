using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NONOGRAM
{
    class Program
    {

        static void Main()
        {
            READER reader = new READER("C:/Users/Zeta/Documents/TestFile.txt");
            String[] Da = reader.GetData();
            Console.WriteLine(Da[0]);
            Console.WriteLine(Da[1]);
            Console.WriteLine();
            Nonogram.Solve(Da[0],Da[1]);
            Console.ReadLine();
        }
        
        

    }
}

