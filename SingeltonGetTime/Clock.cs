using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingeltonGetTime
{
    internal class Clock
    {
        private static Clock instance;
        private static readonly object key = new object();

        public Clock()
        {

        }

        public static Clock GetInstance()
        {
            lock (key)
            {
                if(instance == null)
                    instance = new Clock();
                return instance;
            }
        }
        public void GetTime()
        {
            Console.WriteLine(DateTime.Now); 
        }

    }
}
