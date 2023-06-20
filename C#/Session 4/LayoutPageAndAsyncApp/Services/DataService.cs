using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace LayoutPageAndAsyncApp.Services
{
    public class DataService
    {

        public int GetData()
        {
            Thread.Sleep( 8 *1000);
            return 23;
        }

        public Task<int> GetDataAsync()
        {
            return Task.Run(() => { return GetData(); });
        }
    }
}