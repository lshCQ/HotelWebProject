/**
*┌──────────────────────────────────────────────────────────────┐
*│　描   述：                                                    
*│　作   者：雷斯寒
*│　版   本：1.0                                                 
*│　创建时间：2019/6/16 21:50:31                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: DAL                                   
*│　类   名：EFHelper                                      
*└──────────────────────────────────────────────────────────────┘
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace DAL
{
    public class EFHelper
    {
        private DbContext dbcontext=null;

        public EFHelper(DbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Add<T>(T entity) where T : class
        {
            dbcontext.Entry<T>(entity).State = EntityState.Added;
            //dbcontext.Set<T>().Add(entity);
            //dbcontext.Set<T>().Attach(entity);
            return dbcontext.SaveChanges();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Modify<T>(T entity) where T : class
        {
            dbcontext.Entry<T>(entity).State = EntityState.Modified;//这种方式更新的是更新所有字段，不适合部分字段更新
            return dbcontext.SaveChanges();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Delete<T>(T entity) where T : class
        {
            dbcontext.Entry<T>(entity).State = EntityState.Deleted;
            return dbcontext.SaveChanges();
        }

        
    }
}
