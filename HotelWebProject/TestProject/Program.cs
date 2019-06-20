using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;
using BLL;
namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
 
=======
>>>>>>> ef72d0c0322efb181db581180f7876206efe5f37

            NewsBLL newbll = new NewsBLL();
            //var  catetory = newbll.GetNewsCategory();
            //foreach (var item in catetory)
            //{
            //    Console.WriteLine( item.CategoryId+"\t"+item.CategoryName);
            //}
            //Console.ReadKey();
            //NewsCategory.CategoryId
            //News news = new News();
            //news.NewsTitle = "这是不是一个标题";
            //news.NewsCategory = new NewsCategory {   CategoryId =3 , CategoryName = "社会新闻" };
            //news.NewsContents = "这不是一个正经的内容内容！";
            //news.NewsId = 1000;
            //news.CategoryId = 3;
            //newbll.ModifyNew(news);


<<<<<<< HEAD
 
=======
>>>>>>> ef72d0c0322efb181db581180f7876206efe5f37

            /// <summary>
            /// GetNewsCategory();测试
            /// </summary>
            /// <param name="news"></param>
            /// <returns></returns>
<<<<<<< HEAD
          //  NewsBLL newbll = new NewsBLL();
=======
            //NewsBLL newbll = new NewsBLL();
>>>>>>> ef72d0c0322efb181db581180f7876206efe5f37
            //var catetory = newbll.GetNewsCategory();
            //foreach (var item in catetory)
            //{
            //    Console.WriteLine(item.CategoryId + "\t" + item.CategoryName);
            //}


            /// <summary>
            /// 添加测试
            /// </summary>
            /// <param name="news"></param>
            /// <returns></returns>
            //News news = new News();
            //news.NewsTitle = "这是一个标题";
            //news.NewsCategory= new NewsCategory { CategoryName = "社会新闻" };
            //news.NewsContents = "这是内容内容！";

            //newbll.PublishNew(news);


            /// <summary>
            /// 根据ID查询成功
            /// </summary>
            /// <param name="news"></param>
            /// <returns></returns>
            //var newsget=newbll.GetNewsById(1005);
            //Console.WriteLine(newsget.NewsContents);

            /// <summary>
            /// 根据ID删除
            /// </summary>
            /// <param name="news"></param>
            /// <returns></returns>
            //Console.WriteLine(newbll.DeleteNew(1009));

            /// <summary>
            /// 修改(报错)
            /// </summary>
            /// <param name="news"></param>
            /// <returns></returns>
            //  News news = new News();
            //  news.NewsId = 1005;
            //  news.NewsTitle = "这是不是一个标题";
            ////  NewsCategory NewsCategory = new NewsCategory { CategoryId = 2, CategoryName = "社会新闻" };
            //  news.NewsContents = "这不是一个正经的内容内容！";
            //  news.PublishTime = DateTime.Now;
            //  news.CategoryId = 2;
            // Console.WriteLine(newbll.ModifyNew(news));

            /// <summary>
            /// 查询指定前几条新闻列表
            /// </summary>
            /// <param name="news"></param>
            /// <returns></returns>

            //var list = newbll.ModifyNew(5);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.NewsId);
            //    Console.WriteLine(item.NewsTitle);
            //    Console.WriteLine(item.NewsContents);
            //    Console.WriteLine(item.CategoryId);
            //}

            //Console.WriteLine(newbll.GetCategoryName(2).CategoryName);


            SuggestionBLL suggestionb = new SuggestionBLL();
            ///查寻
            //var list = suggestionb.GetAllSuggestion();
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.ConsumeDesc);
            //    Console.WriteLine(item.CustomerName);
            //    Console.WriteLine(item.Email);
            //    Console.WriteLine(item.StatusId);
            //}

            // Suggestion s = new Suggestion();
            // s.StatusId = 1;
            // s.PhoneNumber = "12345678910";
            // s.SuggestionDesc = "wqfwebr hyiyitr";
            // s.SuggestionTime = DateTime.Now;
            // s.CustomerName = "wwww";
            //Console.WriteLine( suggestionb.AddSuggestion(s));

            //Console.WriteLine(suggestionb.reciveSuggestion(100002,"1"));
            RecruitmentBLL RB = new RecruitmentBLL();
            //查询
            //var list = RB.GetAllRecruitment();
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.EduBackground);
            //    Console.WriteLine(item.PublishTime);
            //    Console.WriteLine(item.RequireCount);
            //    Console.WriteLine(item.Manager);
            //}
            //添加
            //Recruitment r = new Recruitment();
            //r.PostName = "服务员";
            //r.PostType = "兼职";
            //r.PostPlace = "渝北";
            //r.PostDesc = "接待";
            //r.PostRequire = "开朗，细心。";
            //r.Experience = "可无";
            //r.EduBackground = "高中";
            //r.RequireCount = 1;
            //r.PublishTime = DateTime.Now;
            //r.Manager = "www";
            //r.PhoneNumber = "12345678910";
            //r.Email = "444@qq.com";
            //Console.WriteLine(RB.PublishRecruitment(r));

            //Recruitment r = new Recruitment();
            //r.PostId = 100003;
            //r.PostName = "服务员";
            //r.PostType = "兼职";
            //r.PostPlace = "渝北";
            //r.PostDesc = "接待";
            //r.PostRequire = "开朗，细心。";
            //r.Experience = "可无";
            //r.EduBackground = "高中";
            //r.RequireCount = 1;
            //r.PublishTime = DateTime.Now;
            //r.Manager = "eeeeee";
            //r.PhoneNumber = "14146246564";
            //r.Email = "444@qq.com";
            //Console.WriteLine(RB.ModifyRecruitment(r));

            Console.WriteLine(RB.DeleteRecruitment(100004));

            Console.ReadKey();
<<<<<<< HEAD

=======
>>>>>>> ef72d0c0322efb181db581180f7876206efe5f37
        }
    }
}
