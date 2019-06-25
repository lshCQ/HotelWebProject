using BLL;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelWebProject.Controllers
{
    public class NewsController : Controller
    {
       public ActionResult NewsList()
        {
           var newlist = nb.GetNewsByCount(10);
             ViewBag.NewsList = newlist;
            return View();
        }

        public ActionResult NewsDetail(int newsId)
        {
            var news = nb.GetNewsById(newsId);
            ViewBag.News = news;

            return View(news);
        }

        #region 页面
        #region 前台页面
        // GET: News
        public ActionResult News()
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
        /// 查询所有信息
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public string GetAllNews() {

            var rt=nb.GetNewsByCount(5);
            string json = JsonConvert.SerializeObject(rt);
            return json;
        }
        /// <summary>
        /// 删除新闻信息
        /// </summary>
        /// <returns></returns>
        public ActionResult DeleteNews()
        {
            int count= Convert.ToInt32(Request["newsId"]);
            nb.DeleteNew(count);
            return RedirectToAction("NewsManager", "News");
        }

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
            news.CategoryId = Convert.ToInt32(Request["CategoryId"]);
            news.NewsContents = Request["NewsContents"];
            news.PublishTime = DateTime.Now;
            //反馈消息
            string message = string.Empty;
            if (string.IsNullOrEmpty(news.NewsTitle))
            {
                message = "新闻标题不能为空";
            }
            else if (string.IsNullOrEmpty((news.CategoryId).ToString()))
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
<<<<<<< HEAD

            nb.PublishNew(news);


            nb.PublishNew(news);



=======
 
            nb.PublishNew(news);
 

 
            nb.PublishNew(news);
 
>>>>>>> a6ddb9b328909e41f6095911ee096366ba5ee457
            return RedirectToAction("NewsManager", "News");
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