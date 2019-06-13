using BLL;
using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelWebProject.Controllers
{
    public class DishesController : Controller
    {
        #region 页面
        #region 前台页面
        /// <summary>
        ///在线预定
        /// </summary>
        /// <returns></returns>
        // GET: Dishes
        public ActionResult DishesBook()
        {
            return View();
        }

        /// <summary>
        /// 菜品展示
        /// </summary>
        /// <returns></returns>
        // GET: Dishes
        public ActionResult DishesShow()
        {
            return View();
        }
        #endregion
        #region  后台页面
        /// <summary>
        /// 菜品管理
        /// </summary>
        /// <returns></returns>
        public ActionResult DishesManager()
        {
            return View();
        }

        /// <summary>
        /// 菜品添加
        /// </summary>
        /// <returns></returns>

        public ActionResult DishesPublish()
        {
            return View();
        }

        /// <summary>
        /// 菜品编辑
        /// </summary>
        /// <returns></returns>

        public ActionResult DishesUpdate()
        {
            return View();
        }
        #endregion
        #endregion
    }
}