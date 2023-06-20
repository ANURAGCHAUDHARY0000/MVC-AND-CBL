using LayoutPageAndAsyncApp.Services;
using LayoutPageAndAsyncApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LayoutPageAndAsyncApp.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData()
        {
            var beforeThreadId = Thread.CurrentThread.ManagedThreadId;
            Thread.Sleep(5 * 1000);
            var afterThreadId = Thread.CurrentThread.ManagedThreadId;   
            Random random = new Random();
            var result = random.Next();
           var response = new {Result = result, before = beforeThreadId, after = afterThreadId};
          
            return Json(response, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetTimeStamp()
        {
            return PartialView("_timestamp", new TimeStampVM
            {
                Title = "Time Via Ajax",
                Format = "hh:mm:ss"
            });
        }


        public async Task<ActionResult> GetDataAsync()
        {
            DataService service = new DataService();
            var beforeThreadId = Thread.CurrentThread.ManagedThreadId;

            var result = await service.GetDataAsync();
            var afterThreadId = Thread.CurrentThread.ManagedThreadId;
            var response = new { Result = result, before = beforeThreadId, after = afterThreadId };

            return Json(response, JsonRequestBehavior.AllowGet);

        }
    }
}