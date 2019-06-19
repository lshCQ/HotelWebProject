/**
*┌──────────────────────────────────────────────────────────────┐
*│　描   述：                                                    
*│　作   者：雷斯寒
*│　版   本：1.0                                                 
*│　创建时间：2019/6/12 22:26:38                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: BLL                                   
*│　类   名：DishesBookBLL                                      
*└──────────────────────────────────────────────────────────────┘
*/

using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DishesBookBLL
    {
        private DishesBookServices dishesbook = new DishesBookServices();

        /// <summary>
        ///     包房预订(添加预定)
        /// </summary>
        /// <param name="dishesBook"></param>
        /// <returns></returns>
        public int Book(DishesBook dishesBook)
        {
            return dishesbook.Book(dishesBook);
        }

        /// <summary>
        /// 修改预订状态
        /// 0 待审核状态  1 审核通过 -1订单关闭状态
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="status"></param>
        public int ModifyBook(int bookId, string status)
        {
            return dishesbook.ModifyBook(bookId, status);
        }


        /// <summary>
        /// 获取未审核 和 未关闭订单
        /// </summary>
        /// <returns></returns>
        public List<DishesBook> GetAllBook()
        {
                return dishesbook.GetAllBook();
        }
        
    }
}
