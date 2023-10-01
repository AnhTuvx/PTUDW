using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyClass.Model;//Sử dụng các Model đã khai báo: category, topic, product…

namespace _63CNTTN2.Controllers
{
    public class SiteController : Controller
    {
        // GET: Site
        public ActionResult Index()
        {
            
            return View();
        }
    }
}