/**
*┌──────────────────────────────────────────────────────────────┐
*│　描   述：                                                    
*│　作   者：雷斯寒
*│　版   本：1.0                                                 
*│　创建时间：2019/6/12 22:26:19                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: BLL                                   
*│　类   名：DishesBLL                                      
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
    public class DishesBLL
    {
        private DishesServices dishess = new DishesServices();
        /// <summary>
        /// 发布菜品
        /// </summary>
        /// <param name="dishes"></param>
        /// <returns></returns>
        public int AddDishes(Dishes dishes)
        {

            return dishess.AddDishes(dishes);
        }

        /// <summary>
        /// 修改菜品
        /// </summary>
        /// <param name="dishes"></param>
        /// <returns></returns>
        public int ModifyDishes(Dishes dishes)
        {

            return dishess.ModityDishes(dishes);
        }

        /// <summary>
        /// 删除菜品
        /// </summary>
        /// <param name="dishesId"></param>
        /// <returns></returns>
        public int DeleteDishes(int dishesId)
        {
            return dishess.DeleteDishes(dishesId);
        }
        /// <summary>
        /// 获取菜品， 可获取全部和根据查询条件获取
        /// </summary>
        /// <param name="dishesId"></param>
        /// <returns></returns>
        public List<Dishes> GetAllDishes(int categoryId=0)
        {
            return dishess.GetAllDishes(categoryId);
        }


        /// <summary>
        /// 获取菜单分类 （下拉框使用）
        /// </summary>
        ///
        /// <returns></returns>
        public List<DishesCategory> GetAllDishesCategory()
        {           
                return dishess.GetAllDishesCategory();           
        }


        /// <summary>
        /// 根据菜品Id查询菜品名称
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public DishesCategory GetDishesCategoryName(int categoryId)
        {
            
                return dishess.GetDishesCategoryName(categoryId); 
            
        }

        /// <summary>
        /// 根据菜品Id获的菜品  修改使用
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public Dishes GetDishesById(int dishesId)
        {
            return dishess.GetDishesById(dishesId);
        }


    }
}
