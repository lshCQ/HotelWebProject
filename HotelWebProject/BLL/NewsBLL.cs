/**
*┌──────────────────────────────────────────────────────────────┐
*│　描   述：                                                    
*│　作   者：雷斯寒
*│　版   本：1.0                                                 
*│　创建时间：2019/6/12 22:25:52                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: BLL                                   
*│　类   名：NewsBLL                                      
*└──────────────────────────────────────────────────────────────┘
*/

using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
 
=======

>>>>>>> ef72d0c0322efb181db581180f7876206efe5f37

namespace BLL
{
    public class NewsBLL
    {
<<<<<<< HEAD
 
=======

>>>>>>> ef72d0c0322efb181db581180f7876206efe5f37
        private NewsServices newsdll = new NewsServices();

        /// <summary>
        /// 发布新闻   在News表添加一条记录
        /// </summary>
        /// <param name="news"></param>
        /// <returns></returns>
        public int PublishNew(News news)
        {
            return newsdll.PublishNew(news);
        }
        /// <summary>
        /// 删除新闻   在News表删除一条记录
        /// </summary>
        /// <param name="news"></param>
        /// <returns></returns>
        public int DeleteNew(int newsid)
        {
            return newsdll.DeleteNew(newsid);
        }

        /// <summary>
        /// 修改新闻   在News表修改一条记录
        /// </summary>
        /// <param name="news"></param>
        /// <returns></returns>
        public int ModifyNew(News news)
        {
            return newsdll.ModifyNew(news);
        }

        /// <summary>
        /// 查询指定前几条新闻列表
        /// </summary>
        /// <param name="news"></param>
        /// <returns></returns>
        public List<News> GetNewsByCount(int count)
        {
                return newsdll.GetNewsByCount(count); 
        }

        /// <summary>
        /// 根据Id获取新闻信息
        /// </summary>
        /// <param name="newsId"></param>
        /// <returns></returns>
        public News GetNewsById(int newsId)
        {         
                return newsdll.GetNewsById(newsId);   
        }

        /// <summary>
        /// 获取新闻分类
        /// </summary>
        /// <returns></returns>
        public List<NewsCategory> GetNewsCategory()
        {
            return newsdll.GetNewsCategory(); 
        }

        /// <summary>
        /// 根据Id获取分类名称
        /// </summary>
        /// <returns></returns>
        public NewsCategory GetCategoryName(int categoryid)
        {
                return newsdll.GetCategoryName(categoryid);
        }




    }
}
