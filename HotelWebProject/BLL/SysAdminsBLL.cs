/**
*┌──────────────────────────────────────────────────────────────┐
*│　描   述：                                                    
*│　作   者：雷斯寒
*│　版   本：1.0                                                 
*│　创建时间：2019/6/12 22:28:10                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: BLL                                   
*│　类   名：SysAdminsBLL                                      
*└──────────────────────────────────────────────────────────────┘
*/

using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BLL
{
    public class SysAdminsBLL
    {
        SysAdminsServices adminDal = new SysAdminsServices();

        /// <summary>
        /// 根据用户名和密码获取用户对象
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="userpwd"></param>
        /// <returns></returns>
        //public SysAdmins GetAdmin(string userid, string userpwd)
        //{
        //    SysAdmins adminObj = adminDal.GetAdmin(userid, userpwd);
        //    if (adminObj != null)
        //    {
        //        HttpContext.Current.Session["user"] = adminObj;
        //    }
        //    return adminObj;
        //}
        public SysAdmins GetUserById(int userid)
        {
            SysAdmins adminObj = adminDal.GetUserById(userid);
            if (adminObj != null)
            {
                HttpContext.Current.Session["user"] = adminObj;
            }
            return adminObj;
            
        }

    }
}
