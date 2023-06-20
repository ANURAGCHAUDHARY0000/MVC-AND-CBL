using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncAwaitApp.Service
{
    internal class TimePrinterService
    {
        public void Print()
        {
            DateTime startTime = DateTime.UtcNow;
            TimeSpan future = TimeSpan.FromMinutes(.10);

            while(DateTime.UtcNow - startTime < future)
            {
                Debug.WriteLine("delay : " + DateTime.Now.ToString("hh:mm:dd"));
            }
            Debug.WriteLine("Delay over");
        }

        public Task PrintAsync()
        {
            return Task.Run(Print);
        }


        public Task<string> PrintAsyncWithResult()
        {
            return Task.Run(() =>
            {
                Print();
                return "Success from print";
            });
        }
    }
}
