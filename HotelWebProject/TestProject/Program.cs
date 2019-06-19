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


        }
    }
}
