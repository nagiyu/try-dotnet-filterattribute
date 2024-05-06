using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Diagnostics;
using System.Linq;

namespace DotNetCore.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class MultipleFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var attributeUsage = (AttributeUsageAttribute)GetCustomAttribute(GetType(), typeof(AttributeUsageAttribute));
            Debug.WriteLine("OnActionExecuting: MultipleFilterAttribute");
            Debug.WriteLine("AllowMultiple: " + attributeUsage.AllowMultiple);
            Debug.WriteLine("Order: " + Order);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var attributeUsage = (AttributeUsageAttribute)GetCustomAttribute(GetType(), typeof(AttributeUsageAttribute));
            Debug.WriteLine("OnActionExecuted: MultipleFilterAttribute");
            Debug.WriteLine("AllowMultiple: " + attributeUsage.AllowMultiple);
            Debug.WriteLine("Order: " + Order);
        }
    }
}