using DotNetFramework.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetFramework.Controllers
{
    public class SampleController : Controller
    {
        public ActionResult Index()
        {
            return Content("Hello, World!");
        }

        [MultipleFilter(Order = 2)]
        [MultipleFilter(Order = 1)]
        [MultipleFilter]
        public ActionResult Multiple()
        {
            return Content("Multiple Calling!");
        }

        [MultipleFilter]
        public ActionResult SingleMultiple()
        {
            return Content("Multiple Calling!");
        }

        [SingleFilter]
        public ActionResult Single()
        {
            return Content("Single Calling!");
        }
    }
}