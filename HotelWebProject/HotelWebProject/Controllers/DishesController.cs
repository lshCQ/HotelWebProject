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

        DishesBLL db = new DishesBLL();
        public ActionResult DishesShow()
        {
              ViewBag.Disheslist = db.GetAllDishes();

            return View();
        }

        public ActionResult AddDishes()
        {
            Dishes dishes = new Dishes();
            //获取用户请求信息
            dishes.DishesName = Request["DishesName"];
            dishes.UnitPrice = Convert.ToInt32(Request["UnitPrice"]);
            dishes.CategoryId = Convert.ToInt32(Request["CategoryId"]);
            //dishes.dishesImg = DateTime.dishesImg;
            //反馈消息
            string message = string.Empty;
            if (string.IsNullOrEmpty(dishes.DishesName))
            {
                message = "菜品名称不能为空";
            }
            else if (string.IsNullOrEmpty((dishes.UnitPrice).ToString()))
            {
                message = "价格不能为空";
            }
            else if (string.IsNullOrEmpty((dishes.CategoryId).ToString()))
            {
                message = "菜品所属菜系不能为空";
            }
            else
            {
                message = "ok";
            }
            if (message != "ok")
            {
                TempData["LoginMsg"] = message;
                return RedirectToAction("DishesPublish");
            }
            db.AddDishes(dishes);

            return RedirectToAction("DishesManager", "Dishes");
        }


        public ActionResult UpdateDishes()
        {
            Dishes dishes = new Dishes();
            //获取用户请求信息
            dishes.DishesName = Request["DishesName"];
            dishes.UnitPrice = Convert.ToInt32(Request["UnitPrice"]);
            dishes.CategoryId = Convert.ToInt32(Request["CategoryId"]);
            dishes.DishesId= Convert.ToInt32(Request["DishesId"]);
            //dishes.dishesImg = DateTime.dishesImg;
            //反馈消息
            string message = string.Empty;
            if (string.IsNullOrEmpty(dishes.DishesName))
            {
                message = "菜品名称不能为空";
            }
            else if (string.IsNullOrEmpty((dishes.UnitPrice).ToString()))
            {
                message = "价格不能为空";
            }
            else if (string.IsNullOrEmpty((dishes.CategoryId).ToString()))
            {
                message = "菜品所属菜系不能为空";
            }
            else
            {
                message = "ok";
            }
            if (message != "ok")
            {
                TempData["LoginMsg"] = message;
                return RedirectToAction("DishesPublish",new {dishesid= dishes.DishesId });
            }
            db.ModifyDishes(dishes);

            return RedirectToAction("DishesManager", "Dishes");
        }

        /// <summary>
        /// 删除菜品
        /// </summary>
        /// <returns></returns>
        public ActionResult DeleteDishes()
        {
            int count = Convert.ToInt32(Request["dishesid"]);
            db.DeleteDishes(count);
            return RedirectToAction("DishesManager", "Dishes");
        }


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

 
        #endregion
        #region  后台页面
        /// <summary>
        /// 菜品管理
        /// </summary>
        /// <returns></returns>
        public ActionResult DishesManager()
        {
            ViewBag.Disheslist = db.GetAllDishes();
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

        public ActionResult DishesUpdate(int dishesId)
        {
            var dishes = db.GetDishesById(dishesId);
            ViewBag.Dishes = dishes;
            return View(dishes);
        }

        #endregion
        #endregion
    }
}