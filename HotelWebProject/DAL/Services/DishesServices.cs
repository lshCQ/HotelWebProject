/**
*┌──────────────────────────────────────────────────────────────┐
*│　描   述：                                                    
*│　作   者：雷斯寒
*│　版   本：1.0                                                 
*│　创建时间：2019/6/12 22:22:07                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: DAL                                   
*│　类   名：DishesServices                                      
*└──────────────────────────────────────────────────────────────┘
*/
using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// 菜品管理
    /// </summary>
    public class DishesServices
    {

        /// <summary>
        /// 发布菜品
        /// </summary>
        /// <param name="dishes"></param>
        /// <returns></returns>
        public int AddDishes(Dishes dishes)
        {
            using (HotelDBEntities db = new HotelDBEntities())
            {
                db.Dishes.Add(dishes);
                return db.SaveChanges();
            }
        }

        /// <summary>
        /// 修改菜单 默认是修改全部
        /// </summary>
        /// <param name="dishes"></param>
        /// <returns></returns>
        public int ModityDishes(Dishes dishes)
        {
            using (HotelDBEntities db = new HotelDBEntities())
            {
                db.Entry<Dishes>(dishes).State = EntityState.Modified;
                return db.SaveChanges();
            }

        }

        /// <summary>
        /// 删除菜品
        /// </summary>
        /// <param name="dishesId"></param>
        /// <returns></returns>
        public int DeleteDishes(int dishesId)
        {
            Dishes dishes = new Dishes();
            dishes.DishesId = dishesId;
            using (HotelDBEntities db = new HotelDBEntities())
            {
                db.Dishes.Attach(dishes);
                db.Dishes.Remove(dishes);
                return db.SaveChanges();
            }
        }

        /// <summary>
        /// 获取菜品， 可获取全部和根据查询条件获取
        /// </summary>
        /// <returns></returns>
        public List<Dishes> GetAllDishes(int categoryId = 0)
        {
            using (HotelDBEntities db = new HotelDBEntities())
            {
                if (categoryId == 0)
                    return (from d in db.Dishes select d).ToList();
                else
                    return (from d in db.Dishes where d.CategoryId == categoryId select d).ToList();
            }

        }

        /// <summary>
        /// 获取菜单分类 （下拉框使用）
        /// </summary>
        ///
        /// <returns></returns>
        public List<DishesCategory> GetAllDishesCategory()
        {
            using (HotelDBEntities db = new HotelDBEntities())
            {
                return (from dc in db.DishesCategory select dc).ToList();
            }
        }

        /// <summary>
        /// 根据菜品Id查询菜品名称
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public  DishesCategory GetDishesCategoryName(int categoryId)
        {
            using (HotelDBEntities db = new HotelDBEntities())
            {
                return (from dc in db.DishesCategory where dc.CategoryId== categoryId select dc).FirstOrDefault();
            }
        }

        /// <summary>
        /// 根据菜品Id获的菜品  修改使用
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public Dishes GetDishesById(int dishesId)
        {
            using (HotelDBEntities db = new HotelDBEntities())
            {
                return (from d in db.Dishes where d.DishesId == dishesId select d).FirstOrDefault();
            }
        }



    }
}
