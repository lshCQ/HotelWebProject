/**
*┌──────────────────────────────────────────────────────────────┐
*│　描   述：                                                    
*│　作   者：雷斯寒
*│　版   本：1.0                                                 
*│　创建时间：2019/6/12 22:23:36                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: DAL                                   
*│　类   名：NewsServices                                      
*└──────────────────────────────────────────────────────────────┘
*/

using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class NewsServices
    {
        //使用数据库通用类
        private EFHelper helper = new EFHelper(new HotelDBEntities());


        /// <summary>
        /// 发布新闻   在News表添加一条记录
        /// </summary>
        /// <param name="news"></param>
        /// <returns></returns>
        public int PublishNew(News news)
        {
            //不使用EFhelper
            //using (HotelDBEntities efdb = new HotelDBEntities())
            //{
            //    efdb.News.Add(news);
            //    return  efdb.SaveChanges();
            //}

            //调用存储过程
            //SqlParameter[] sqlpar = new SqlParameter[]
            //{
            //    new SqlParameter ("@NewsTitle",news.NewsTitle),
            //};
            //using (HotelDBEntities efdb = new HotelDBEntities())
            //{
            //    return efdb.Database.ExecuteSqlCommand("excute usp_AddNews @NewsTitle", sqlpar);
            //}

            //使用EFHelper
            return helper.Add(news);
        }




        /// <summary>
        /// 删除新闻   在News表删除一条记录
        /// </summary>
        /// <param name="news"></param>
        /// <returns></returns>
        public int DeleteNew(int newsid)
        {
            News news = new News() { NewsId = newsid };
            return helper.Delete(news);
        }

        /// <summary>
        /// 修改新闻   在News表修改一条记录
        /// </summary>
        /// <param name="news"></param>
        /// <returns></returns>
        public int ModifyNew(News news)
        {
            return helper.Modify(news);
        }


        /// <summary>
        /// 查询指定前几条新闻列表
        /// </summary>
        /// <param name="news"></param>
        /// <returns></returns>
        public List<News> ModifyNew(int count)
        {
            using (HotelDBEntities efdb = new HotelDBEntities())
            {
                return (from n in efdb.News orderby n.PublishTime descending select n).Take(count).ToList();
            }
        }

        /// <summary>
        /// 根据Id获取新闻信息
        /// </summary>
        /// <param name="newsId"></param>
        /// <returns></returns>
        public News GetNewsById(int newsId)
        {
            using (HotelDBEntities efdb = new HotelDBEntities())
            {
                return (from n in efdb.News where newsId == n.NewsId select n).FirstOrDefault();
            }
        }

        /// <summary>
        /// 获取新闻分类
        /// </summary>
        /// <returns></returns>
        public List<NewsCategory> GetNewsCategory()
        {
            using (HotelDBEntities efdb = new HotelDBEntities())
            {
                return (from n in efdb.NewsCategory select n).ToList<NewsCategory>();
            }
        }

        /// <summary>
        /// 根据Id获取分类名称
        /// </summary>
        /// <returns></returns>
        public  NewsCategory GetCategoryName(int categoryid)
        {
            using (HotelDBEntities efdb = new HotelDBEntities())
            {
                return (from n in efdb.NewsCategory where n.CategoryId==categoryid  select n).FirstOrDefault();
            }
        }



    }
}
