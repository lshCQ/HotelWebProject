using BLL;
using Models;
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

        NewsBLL nb = new NewsBLL();


        #region 方法，后台
        /// <summary>
        /// 添加新闻信息
        /// </summary>
        /// <returns></returns>
        [ValidateInput(false)]
        public ActionResult AddNews()
        {
            News news = new News();
            //获取用户请求信息
            news.NewsTitle = Request["NewsTitle"];
            news.NewsCategory = new NewsCategory { CategoryName = Request["CategoryId"]}; //(NewsCategory)Convert.ChangeType(Request["CategoryId"], typeof(NewsCategory)); 
            news.NewsContents = Request["NewsContents"];
            //反馈消息
            string message = string.Empty;
            if (string.IsNullOrEmpty(news.NewsTitle) )
            {
                    message = "新闻标题不能为空";
            }
            else if (string.IsNullOrEmpty(news.NewsCategory.ToString()))
            {
                    message = "请选择新闻类型";
            }
            else if (string.IsNullOrEmpty(news.NewsContents))
            {
                    message = "新闻内容不能为空";
            }
            else
            {
                message = "ok";
            }
            if (message != "ok")
            {
                TempData["LoginMsg"] = message;
                return RedirectToAction("NewsPublish");
            }

         //   nb.AddNew(news);

            return RedirectToAction("NewsList", "News");
        }


        #endregion


        #region  帮助方法
        /// <summary>
        /// 获取html中纯文本 
        /// </summary> 
        /// <param name="html">html</param>
        /// <returns>纯文本</returns>
        public static string GetHtmlText(string html)
        {
            html = System.Text.RegularExpressions.Regex.Replace(html, @"<\/*[^<>]*>", "", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            html = html.Replace("\r\n", "").Replace("\r", "").Replace("&nbsp;", "").Replace(" ", "");
            return html;
        }
        #endregion

    }
}