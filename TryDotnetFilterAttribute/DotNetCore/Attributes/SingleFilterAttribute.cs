using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Diagnostics;
using System.Linq;

namespace DotNetFramework.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class SingleFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var attributeUsage = (AttributeUsageAttribute)GetCustomAttribute(GetType(), typeof(AttributeUsageAttribute));
            Debug.WriteLine("OnActionExecuting: SingleFilterAttribute");
            Debug.WriteLine("AllowMultiple: " + attributeUsage.AllowMultiple);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var attributeUsage = (AttributeUsageAttribute)GetCustomAttribute(GetType(), typeof(AttributeUsageAttribute));
            Debug.WriteLine("OnActionExecuted: SingleFilterAttribute");
            Debug.WriteLine("AllowMultiple: " + attributeUsage.AllowMultiple);
        }
    }
}