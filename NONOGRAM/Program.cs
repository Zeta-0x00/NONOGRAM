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
            String j = Da[0];
            String k = Da[1];
            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.WriteLine();
            //Nonogram.Solve(j,k);
            Console.ReadLine();
        }
        
        

    }
}

