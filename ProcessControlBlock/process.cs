using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessControlBlock
{
    class process
    {

        public PCB pcb;
        public static Random rd = new Random();
        int[] pro;
        public process()
        {
            pro = new int[rd.Next(2, 20)];
            for (int i = 0; i < pro.Length; i++)
            {
                pro[i] = rd.Next(0, 100);
            }
            pcb = new PCB(pro.Length);
        }

        public void setpro(int val, int index)
        {
            if (index < pro.Length - 1 && index > -1)
            {
                pro[index] = val;
            }
            else { Console.WriteLine("Index out of bound"); }
        }

    }
}
