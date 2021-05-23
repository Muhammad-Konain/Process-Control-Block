using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessControlBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many process would you like to create : ");
            int nump = Convert.ToInt32(Console.ReadLine());
            process[] pcarr = new process[nump];
            for (int i = 0; i < pcarr.Length; i++)
            {
                pcarr[i] = new process();
            }
            shedulling sd = new shedulling();
            sd.RoundRobin(pcarr);
            sd.display(pcarr);
            Console.ReadKey();
            
        }
    }
}

