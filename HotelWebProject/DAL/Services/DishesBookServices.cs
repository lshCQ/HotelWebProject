/**
*┌──────────────────────────────────────────────────────────────┐
*│　描   述：                                                    
*│　作   者：雷斯寒
*│　版   本：1.0                                                 
*│　创建时间：2019/6/12 22:22:41                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: DAL                                   
*│　类   名：DishesBookServices                                      
*└──────────────────────────────────────────────────────────────┘
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL
{
    /// <summary>
    /// 预订管理
    /// </summary>
    public class DishesBookServices
    {

        /// <summary>
        ///     包房预订
        /// </summary>
        /// <param name="dishesBook"></param>
        /// <returns></returns>
        public int Book(DishesBook dishesBook)
        {
            dishesBook.OrderStatus = 0;
            using (HotelDBEntities db = new HotelDBEntities())
            {
                db.DishesBook.Add(dishesBook);
                
                return db.SaveChanges();
            }

        }

        /// <summary>
        /// 修改预订状态
        /// 0 待审核状态  1 审核通过 -1订单关闭状态
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public int ModifyBook(int bookId,string status)
        {
            /*
            1.封装一个实体，所有属性都写上
            2.查询到实体，修改某些属性
            3.创建一个对象--》给主键赋值--》附加到上下文对象--》给修改的字段赋值--》提交保存

             */

            using (HotelDBEntities db = new HotelDBEntities()) 
            {
                DishesBook dishesBook = new DishesBook();
                dishesBook.BookId = bookId;
                db.DishesBook.Attach(dishesBook);
                dishesBook.OrderStatus = Convert.ToInt32(status);
                return db.SaveChanges();
            }

        }

        /// <summary>
        /// 获取未审核 和 未关闭订单
        /// </summary>
        /// <returns></returns>
        public List<DishesBook> GetAllBook()
        {
            using (HotelDBEntities db = new HotelDBEntities())
            {
                var list = (from b in db.DishesBook where b.OrderStatus == 0 || b.OrderStatus == 1 orderby b.BookTime descending select b).ToList();
                return list;
            }
        }


    }
}
