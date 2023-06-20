using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LayoutPageAndAsyncApp.ViewModel
{
    public class TimeStampVM
    {

        public string Title { get; set; }
        public string Format { get; set; }  

        public TimeStampVM()
        {
            this.Title = "Date and Time";
        }
    }
}