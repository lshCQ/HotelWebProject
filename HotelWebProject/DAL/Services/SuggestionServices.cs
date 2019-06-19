/**
*┌──────────────────────────────────────────────────────────────┐
*│　描   述：                                                    
*│　作   者：雷斯寒
*│　版   本：1.0                                                 
*│　创建时间：2019/6/12 22:24:32                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: DAL                                   
*│　类   名：SuggestionServices                                      
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
    /// 投诉管理
    /// </summary>
    public class SuggestionServices
    {
        /// <summary>
        /// 提交投诉
        /// </summary>
        public int AddSuggestion(Suggestion suggestion)
        {
            using (HotelDBEntities db = new HotelDBEntities())
            {
                db.Suggestion.Add(suggestion);
                return db.SaveChanges();
            }
        }

        /// <summary>
        /// 查询所有投诉
        /// </summary>
        public List<Suggestion> GetAllSuggestion()
        {
            using (HotelDBEntities db = new HotelDBEntities())
            {          
                    return (from d in db.Suggestion select d).ToList();
            }

        }

        /// <summary>
        /// 受理投诉
        /// </summary>
        /// 把受理投诉改为已受理。极为修改StatusId值。0>>1

        public int reciveSuggestion(int suggestionid, string statusid)
        {
                using (HotelDBEntities db = new HotelDBEntities())
                {
                Suggestion Suggestion = new Suggestion();
                Suggestion.SuggestionId = suggestionid;
                db.Suggestion.Attach(Suggestion);
                Suggestion.StatusId = Convert.ToInt32(statusid);
                return db.SaveChanges();
            }

        }

      
        

    }
}
