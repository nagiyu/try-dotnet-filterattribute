using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetFramework.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class MultipleFilterAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("OnActionExecuting: MultipleFilterAttribute");
            Debug.WriteLine("AllowMultiple: " + AllowMultiple);
            Debug.WriteLine("Order: " + Order);
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("OnActionExecuted: MultipleFilterAttribute");
            Debug.WriteLine("AllowMultiple: " + AllowMultiple);
            Debug.WriteLine("Order: " + Order);
        }
    }
}