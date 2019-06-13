using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelWebProject.Controllers
{
    public class NewsController : Controller
    {
        #region 页面
        #region 前台页面
        // GET: News
        public ActionResult News()
        {
            return View();
        }
        public ActionResult NewsList()
        {
            return View();
        }
        #endregion
        #region 后台页面
        public ActionResult NewsPublish()
        {
            return View();
        }
        public ActionResult NewsManager()
        {
            return View();
        }
        public ActionResult NewsUpdate()
        {
            return View();
        }
        #endregion
        #endregion
    }
}