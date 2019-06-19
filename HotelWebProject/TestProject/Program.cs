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

            NewsBLL newbll = new NewsBLL();
            //var  catetory = newbll.GetNewsCategory();
            //foreach (var item in catetory)
            //{
            //    Console.WriteLine( item.CategoryId+"\t"+item.CategoryName);
            //}
            //Console.ReadKey();
            //NewsCategory.CategoryId
            News news = new News();
            news.NewsTitle = "这是不是一个标题";
            news.NewsCategory = new NewsCategory {   CategoryId =3 , CategoryName = "社会新闻" };
            news.NewsContents = "这不是一个正经的内容内容！";
            news.NewsId = 1000;
            news.CategoryId = 3;
            newbll.ModifyNew(news);


=======

            /// <summary>
            /// GetNewsCategory();测试
            /// </summary>
            /// <param name="news"></param>
            /// <returns></returns>
            NewsBLL newbll = new NewsBLL();
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

            var list = newbll.ModifyNew(5);
            foreach (var item in list)
            {
                Console.WriteLine(item.NewsId);
                Console.WriteLine(item.NewsTitle);
                Console.WriteLine(item.NewsContents);
                Console.WriteLine(item.CategoryId);
            }

            //Console.WriteLine(newbll.GetCategoryName(2).CategoryName);


            Console.ReadKey();
>>>>>>> fa72679c74b1186f466bfb3aa556a232df600e49
        }
    }
}
