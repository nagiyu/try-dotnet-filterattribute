using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetFramework.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class SingleFilterAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("OnActionExecuting: SingleFilterAttribute");
            Debug.WriteLine("AllowMultiple: " + AllowMultiple);
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("OnActionExecuted: SingleFilterAttribute");
            Debug.WriteLine("AllowMultiple: " + AllowMultiple);
        }
    }
}