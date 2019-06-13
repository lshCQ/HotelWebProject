/**
*┌──────────────────────────────────────────────────────────────┐
*│　描   述：                                                    
*│　作   者：雷斯寒
*│　版   本：1.0                                                 
*│　创建时间：2019/6/12 22:24:50                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: DAL                                   
*│　类   名：SysAdminsServices                                      
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
    public class SysAdminsServices
    {
        SqlHelper help = new SqlHelper();
        public log4net.ILog logger = log4net.LogManager.GetLogger(typeof(SysAdminsServices));

        /// <summary>
        /// 根据用户名和密码获取用户对象
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="userpwd"></param>
        /// <returns></returns>
        public Models.SysAdmins GetAdmin(string userid, string userpwd)
        {
            string sql = "SELECT LoginId, LoginName, LoginPwd FROM SysAdmins  WHERE LoginId='{0}' and LoginPwd='{1}' ";
            SysAdmins adminModel = null;
            try
            {
                SqlDataReader reader = help.GetReader(string.Format(sql, userid, userpwd));
                if (reader.Read())
                {
                    adminModel = new SysAdmins();

                    adminModel.LoginId = Convert.ToInt32(reader["LoginId"]);
                    adminModel.LoginName = reader["LoginName"].ToString();
                    adminModel.LoginPwd = reader["LoginPwd"].ToString();
                   
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message, ex);
                //写日志
            }
            return adminModel;

        }


    }
}
