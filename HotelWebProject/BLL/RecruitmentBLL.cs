/**
*┌──────────────────────────────────────────────────────────────┐
*│　描   述：                                                    
*│　作   者：雷斯寒
*│　版   本：1.0                                                 
*│　创建时间：2019/6/12 22:27:49                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: BLL                                   
*│　类   名：RecruitmentBLL                                      
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
    public class RecruitmentBLL
    {
        private RecruitmentServices recruitments = new RecruitmentServices();

        ///<summary>
        ///发布招聘信息
        ///<summary>
        public int PublishRecruitment(Recruitment recruitment)
        {
            return recruitments.PublishRecruitment(recruitment);
        }

        ///<summary>
        ///修改招聘信息，默认修改该记录得所有信息
        ///<summary>
        public int ModifyRecruitment(Recruitment recruitment)
        {
            return recruitments.ModifyRecruitment(recruitment);
        }

        ///<summary>
        ///删除招聘信息
        ///<summary>
        public int DeleteRecruitment(int postid)
        {
            return recruitments.DeleteRecruitment(postid);
        }

        ///<summary>
        ///查询所有招聘信息
        ///<summary>

        public List<Recruitment> GetAllRecruitment()
        {
            return recruitments.GetAllRecruitment();
        }
    }
}