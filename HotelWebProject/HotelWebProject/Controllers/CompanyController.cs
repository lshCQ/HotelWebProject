using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelWebProject.Controllers
{
    public class CompanyController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        #region 页面

        #region 前台页面
        // GET: Company
        public ActionResult ComDesc()
        {
            return View();
        }
        // GET: Company
        public ActionResult Environment()
        {
            return View();
        }
        public ActionResult JoinUs()
        {
            return View();
        }
        public ActionResult Suggestions()
        {
            return View();
        }
        public ActionResult RecruitmentList()
        {
            return View();
        }
        public ActionResult RecruitmentDetail()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }
        #endregion
        /// <summary>
        /// 后台页面
        /// </summary>
        /// <returns></returns>

        #region  后台管理页面
        public ActionResult BookManager()
        {
            return View();
        }
        public ActionResult RecruitmentManager()
        {
            return View();
        }
        public ActionResult RecruitmentPublish()
        {
            return View();
        }
        public ActionResult RecruitmentUpdate()
        {
            return View();
        }
        public ActionResult SuggestionManager()
        {
            return View();
        }
        #endregion

        #endregion
    }
}