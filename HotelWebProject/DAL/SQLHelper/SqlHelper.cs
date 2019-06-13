using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    /// <summary>
    /// 通用数据访问类
    /// </summary>
   public class SqlHelper
    {

        private readonly string constr = ConfigurationManager.ConnectionStrings["conString"].ToString();

       #region 访问类基础形式
       /// <summary>
       /// 增删改
       /// </summary>
       /// <param name="sql"></param>
       /// <returns></returns>
       public int Update(string sql)
       {
           SqlConnection con = new SqlConnection(constr);
           SqlCommand cmd =new  SqlCommand(sql,con);
           int exeLine = 0;
           try
           {
               con.Open();
               exeLine = cmd.ExecuteNonQuery();
           }
           catch (Exception ex)
           {
               throw ex;
           }
           finally
           {
               con.Close();
           }
           return exeLine;
       }

       /// <summary>
       /// 获取单一结果
       /// </summary>
       /// <param name="sql"></param>
       /// <returns></returns>
       public object GetSingle(string sql) 
       {
           SqlConnection con = new SqlConnection(constr);
           SqlCommand cmd = new SqlCommand(sql,con);
           object result = null;
           try
           {
               con.Open();
               result = cmd.ExecuteScalar();
           }
           catch (Exception ex)
           {
               throw ex;
           }
           finally 
           {
               con.Close();
           }
           return result;
       }

       public SqlDataReader GetReader(string sql) 
       {
           SqlConnection con = new SqlConnection(constr);
           SqlCommand cmd = new SqlCommand(sql,con);
           SqlDataReader reader = null;
           try
           {
               con.Open();
               reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
           }
           catch (Exception ex)
           {
               throw ex;
           }
           return reader;
       }
        #endregion

       /// <summary>
       /// 从数据库读取数据
       /// </summary>
       /// <param name="sqlText">sql语句</param>
       /// <param name="param">参数</param>
       /// <param name="isStoredProcedure">是否为存储过程</param>
       /// <returns></returns>
       public  SqlDataReader GetSqlDataReader(string sqlText, SqlParameter[] param = null, bool isStoredProcedure = false)
       {
           SqlConnection conn = new SqlConnection(constr);
           SqlCommand cmd = new SqlCommand();
           cmd.Connection = conn;
           cmd.CommandText = sqlText;

           if (isStoredProcedure)
           {
               cmd.CommandType = CommandType.StoredProcedure;
           }

           if (param != null)
           {
               cmd.Parameters.AddRange(param);
           }

           conn.Open();

           return cmd.ExecuteReader(CommandBehavior.CloseConnection);
       }

       /// <summary>
       /// 执行返回单一结果的SQL语句查询
       /// </summary>
       /// <param name="sqlText">sql语句</param>
       /// <param name="param">参数</param>
       /// <param name="isStoredProcedure">是否为存储过程</param>
       /// <returns></returns>
       public  object ExecuteSingleResult(string sqlText, SqlParameter[] param = null, bool isStoredProcedure = false)
       {
           SqlConnection conn = new SqlConnection(constr);
           SqlCommand cmd = new SqlCommand();
           cmd.Connection = conn;
           cmd.CommandText = sqlText;

           if (isStoredProcedure)
           {
               cmd.CommandType = CommandType.StoredProcedure;
           }

           if (param != null)
           {
               cmd.Parameters.AddRange(param);
           }

           conn.Open();

           object executeResult = cmd.ExecuteScalar();

           conn.Close();

           return executeResult;
       }
    }
}
