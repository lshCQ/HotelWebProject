using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Models;
namespace HotelWebProject.Controllers
{
    public class CompanyController : Controller
    {
        NewsBLL news = new NewsBLL();
        RecruitmentBLL recruitmentb = new RecruitmentBLL();
        public ActionResult Index()
        {
            //获得前五条新闻
          var  newslist =  news.GetNewsByCount(5);
            ViewBag.newslist = newslist;
            return View();
        }

        //删除招聘信息
        public ActionResult DeleteRecruitment()
        {
            int count = Convert.ToInt32(Request["postId"]);
            recruitmentb.DeleteRecruitment(count);
            return RedirectToAction("RecruitmentManager", "Company");
        }
        //添加招聘信息
        public ActionResult SubmitRecruimentInfo()
        {
            Recruitment recruitments = new Recruitment();
            //获取用户请求信息
            recruitments.PostName = Request["PostName"];
            recruitments.PostType = Request["PostType"];
            recruitments.Experience = Request["Experience"];
            recruitments.EduBackground = Request["EduBackground"];
            recruitments.RequireCount = Convert.ToInt32( Request["RequireCount"]);
            recruitments.PostPlace = Request["PostPlace"];
            recruitments.PostRequire = Request["PostRequire"];
            recruitments.PostDesc = Request["PostDesc"];
            recruitments.Manager = Request["Manager"];
            recruitments.PhoneNumber = Request["PhoneNumber"];
            recruitments.Email = Request["Email"];
            recruitments.PublishTime = DateTime.Now;
            //反馈消息
            string message = string.Empty;
            if (string.IsNullOrEmpty(recruitments.PostName))
            {
                message = "职称不能为空";
            }
            else if (string.IsNullOrEmpty(recruitments.PostPlace))
            {
                message = "工作地点不能为空";
            }
            else
            {
                message = "ok";
            }
            if (message != "ok")
            {
                TempData["LoginMsg"] = message;
                return RedirectToAction("RecruitmentPublish");
            }
            recruitmentb.PublishRecruitment(recruitments);

            return RedirectToAction("RecruitmentManager", "Company");
        }
        //修改
        public ActionResult RecruitmentUpdates()
        {
            Recruitment recruitments = new Recruitment();
            //获取用户请求信息
            recruitments.PostName = Request["PostName"];
            recruitments.PostType = Request["PostType"];
            recruitments.Experience = Request["Experience"];
            recruitments.EduBackground = Request["EduBackground"];
            recruitments.RequireCount = Convert.ToInt32(Request["RequireCount"]);
            recruitments.PostPlace = Request["PostPlace"];
            recruitments.PostRequire = Request["PostRequire"];
            recruitments.PostDesc = Request["PostDesc"];
            recruitments.Manager = Request["Manager"];
            recruitments.PhoneNumber = Request["PhoneNumber"];
            recruitments.Email = Request["Email"];
            recruitments.PostId = Convert.ToInt32(Request["PostId"]); 
            //反馈消息
            string message = string.Empty;
            if (string.IsNullOrEmpty(recruitments.PostName))
            {
                message = "职称不能为空";
            }
            else if (string.IsNullOrEmpty(recruitments.PostPlace))
            {
                message = "工作地点不能为空";
            }
            else
            {
                message = "ok";
            }
            if (message != "ok")
            {
                TempData["LoginMsg"] = message;
                return RedirectToAction("RecruitmentUpdate",new { postid= recruitments.PostId });
            }
            recruitmentb.ModifyRecruitment(recruitments);

            return RedirectToAction("RecruitmentManager", "Company");
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
            var recruitmentList = recruitmentb.GetAllRecruitment();
            ViewBag.recruitmentList = recruitmentList;
            return View();

        }
        public ActionResult RecruitmentDetail(int postId)
        {
            var recruitment = recruitmentb.GetRecruitmentById(postId);
            ViewBag.Recruitment = recruitment;
            return View(recruitment);
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
            var recruitmentList = recruitmentb.GetAllRecruitment();
            ViewBag.recruitmentList = recruitmentList;
            return View();
        }
        public ActionResult RecruitmentPublish()
        {
            return View();
        }
        public ActionResult RecruitmentUpdate(int postId)
        {
            var recruitmentList = recruitmentb.GetRecruitmentById(postId);
            ViewBag.recruitmentList = recruitmentList;
            return View(recruitmentList);
        }
        public ActionResult SuggestionManager()
        {
            return View();
        }
        #endregion

        #endregion
    }
}