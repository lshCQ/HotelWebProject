using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelDBEntities efdb = new HotelDBEntities();
            //DishesBook  dis = efdb.DishesBook.SingleOrDefault(s=>s.BookId== 10000);

            News news = new News();
            news.NewsTitle = "这是一个标题";
            news.NewsCategory= new NewsCategory { CategoryName = "社会新闻" };
            news.NewsContents = "这是内容内容！";

            EFHelper ef = new EFHelper(new HotelDBEntities());
            ef.Add(news);


            //使用方式一：查询单一结果
            News stu1 = efdb.News.SingleOrDefault(s => s.NewsTitle == "这是一个标题");//数据库查询结构为空，该方法返回null;数据库查询结果多个，会报错
            if (stu1 != null)
            {
                Console.WriteLine("内容：{0}，id：{1}", stu1.NewsContents, stu1.NewsId);
            }

            Console.ReadKey();

        }
    }
}
