using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelWebProject.Controllers
{
    public class SysAdminController : Controller
    {

        #region  后台登录页面
        // GET: SysAdmin
        public ActionResult AdminLogin()
        {
            return View();
        }
        public ActionResult AdminMain()
        {
            return View();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 登录
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            //获取用户请求信息
            var uname = Request["LoginId"];
            var pwd = Request["LoginPwd"];
            //反馈消息
            string message = string.Empty;
            if (string.IsNullOrEmpty(uname) || string.IsNullOrEmpty(pwd))
            {
                if (string.IsNullOrEmpty(uname))
                {
                    message = "用户名不能为空";
                }
                else
                {
                    message = "密码不能为空";
                }
            }
            else
            {
                //检验账户是否存在
                SysAdminsBLL admin = new SysAdminsBLL();
                SysAdmins adminModel = admin.GetAdmin(uname, pwd);
                if (adminModel != null)
                {
                    message = "ok";
                }
                else
                {
                    message = "用户名或密码有误";
                }

            }

            if (message != "ok")
            {
                TempData["LoginMsg"] = message;
                return RedirectToAction("AdminLogin");
            }
            return RedirectToAction("AdminMain", "SysAdmin");
        }
        /// <summary>
        /// 退出登陆
        /// </summary>
        /// <returns></returns>
        public ActionResult ExitSys() {         
                Session["user"] = null;
                return RedirectToAction("AdminLogin", "SysAdmin");            
        }
        #endregion
    }
}