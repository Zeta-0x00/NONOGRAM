using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace NONOGRAM
{
    class Program
    {

        static void Main()
        {


            READER reader = new READER("");//In this part you need paste the path file, the files are on directory "Test Files"
            List<List<String>> Da = reader.GetData();
            string x = "";
            for (int i = 0; i < Da[0].Count; i++)
            {
                x = x + Da[0][i];
                if (i < Da[0].Count-1)
                {
                    x = x + ' ';
                }
            }
            string y = "";
            for (int i = 0; i < Da[1].Count; i++)
            {
                y = y + Da[1][i];
                if (i < Da[1].Count - 1)
                {
                    y = y + ' ';
                }
            }
            Console.WriteLine(x);
            Console.WriteLine(y);
            Stopwatch watch = new Stopwatch();
             watch.Start();
            Nonogram.Solve(x, y);
            watch.Stop();
             Console.WriteLine(watch.Elapsed);
            Console.ReadLine();
        }
        
        

    }
}

