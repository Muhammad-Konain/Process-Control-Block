using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessControlBlock
{
    class shedulling
    {
        static int totaltime = 0;
        static Queue<process> readyqueue = new Queue<process>();
        int quantamsize = 0;


        public  void RoundRobin(process[] arr)
        {
            quantamsize = arr[0].pcb.getexetime();
            process temp;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].pcb.getexetime() < quantamsize)
                {
                    quantamsize = arr[i].pcb.getexetime();
                }
                readyqueue.Enqueue(arr[i]);
                arr[i].pcb.setarrivaltime(totaltime);
                totaltime++;
            }

            while (readyqueue.Count != 0)
            {

                temp = readyqueue.Dequeue();
                int exeleft = (temp.pcb.getexetime() - 1) - temp.pcb.getcurntind();

                // if the process is running for the first time, this assigns starting time
                if (temp.pcb.getcurntind() == 0) { temp.pcb.setstarttime(totaltime); }


                // if the quantums left to be executed are greater than the quantam size
                if (exeleft - quantamsize > 0)
                {
                    totaltime = totaltime + quantamsize;
                    temp.pcb.setcurntind(quantamsize);
                    readyqueue.Enqueue(temp);
                }
                else // if the instrctions left are less than quantam size
                {
                    if (exeleft - quantamsize == 0)
                    {
                        temp.pcb.setcurntind(quantamsize);
                        totaltime = totaltime + quantamsize;
                        temp.pcb.setfinsh(totaltime);
                    }
                    else
                    {
                        totaltime = totaltime + exeleft;
                        temp.pcb.setcurntind(exeleft);
                        temp.pcb.setfinsh(totaltime);
                    }
                }

            }
        }
        
        public void display(process[] arr)
        {
            Console.WriteLine("\n........PROCESS DETAILS........\n");
            Console.WriteLine("\nQuantum size : {0}", quantamsize);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].pcb.dispalypcb();
            }
        }
    }
}
