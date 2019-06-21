/**
*┌──────────────────────────────────────────────────────────────┐
*│　描   述：                                                    
*│　作   者：雷斯寒
*│　版   本：1.0                                                 
*│　创建时间：2019/6/12 22:27:59                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: BLL                                   
*│　类   名：SuggestionBLL                                      
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
    public class SuggestionBLL
    {
        private SuggestionServices suggestions = new SuggestionServices();

        /// <summary>
        /// 提交投诉
        /// </summary>
        public int AddSuggestion(Suggestion suggestion)
        {
            return suggestions.AddSuggestion(suggestion);
        }

        /// <summary>
        /// 查询所有投诉
        /// </summary>
        public List<Suggestion> GetAllSuggestion()
        {
            return suggestions.GetAllSuggestion();
        }

        /// <summary>
        /// 受理投诉
        /// </summary>
        /// 把受理投诉改为已受理。极为修改StatusId值。0>>1

        public int ReciveSuggestion(int suggestionid, string statusid)
        {
            return suggestions.ReciveSuggestion(suggestionid, statusid);
        }
    }
}
