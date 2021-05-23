using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessControlBlock
{
    class PCB
    {
        public string processid = "AFD-";
        private int start;
        private int arrivaltime;
        private int currentind = 0;
        private int exectiontime = 0;
        private int finishtime = 0;

        public PCB(int x)
        {
            if (x > 0)
            {
                exectiontime = x;
                processid = processid + process.rd.Next(1, 1000);
            }
            else { Console.WriteLine("Invalid execution time!!"); }
        }

        //getter and seter regions

        #region start tine
        public void setstarttime(int dt)
        {
            if (dt >0) { start = int.Parse(dt.ToString()); }
        }

        public int getstarttime() { return start; }
        #endregion 

        #region execution time
        public void setexetime(int x)
        {
            if (x > 0) { exectiontime = x; }
            else { Console.WriteLine("Invalid execution time!!!"); }
        }

        public int getexetime() { return exectiontime; }
        #endregion

        #region currentindex
        public int getcurntind() { return currentind; }
        public void setcurntind(int x)
        {
            if ((currentind + x) < exectiontime)
            {
                currentind = currentind + x;
            }
            else { Console.WriteLine("invalid index"); }
        }
        #endregion

        #region arrival time
        public void setarrivaltime(int x)
        {
            if (x >= 0) { arrivaltime = x; }
            else { Console.WriteLine("arrival time is invalid"); }
        }

        public int getarrivaltime() { return arrivaltime; }
        #endregion

        #region finish time
        public void setfinsh(int x)
        {
            if (x > 0) { finishtime = x; }
            else { Console.WriteLine("Invalid finsh time"); }
        }

        public int getfinshtime() { return finishtime; }
        #endregion


        public void dispalypcb()
        {
            Console.WriteLine("\n\tProcess ID : {0}\n\tExecution time : {1}\n\tArrival Time : {2}\n\tStart Time : {3}\n\tFinsih Time : {4}\n\n"
                , processid,exectiontime,arrivaltime,start,finishtime);
        }
    }
}