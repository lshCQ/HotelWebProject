/**
*┌──────────────────────────────────────────────────────────────┐
*│　描   述：                                                    
*│　作   者：雷斯寒
*│　版   本：1.0                                                 
*│　创建时间：2019/6/12 22:24:15                             
*└──────────────────────────────────────────────────────────────┘
*┌──────────────────────────────────────────────────────────────┐
*│　命名空间: DAL                                   
*│　类   名：RecruitmentServices                                      
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
    /// 招聘管理
    /// </summary>
    public class RecruitmentServices
    {
        ///<summary>
        ///发布招聘信息
        ///<summary>
        public int PublishRecruitment(Recruitment recruitment)
        {
            using (HotelDBEntities hdb = new HotelDBEntities())
            {
                hdb.Recruitment.Add(recruitment);
                return hdb.SaveChanges();
            }
        }

        ///<summary>
        ///修改招聘信息，默认修改该记录得所有信息
        ///<summary>
        public int ModifyRecruitment(Recruitment recruitment)
        {
            using (HotelDBEntities hdb = new HotelDBEntities())
            {
                hdb.Entry<Recruitment>(recruitment).State = EntityState.Modified;
                return hdb.SaveChanges();
            }
        }

        ///<summary>
        ///删除招聘信息
        ///<summary>
        public int DeleteRecruitment(int postid)
        {
            Recruitment recruitment = new Recruitment();
            recruitment.PostId = postid;
            using (HotelDBEntities hdb = new HotelDBEntities())
            {
                hdb.Recruitment.Attach(recruitment);
                hdb.Recruitment.Remove(recruitment);
                return hdb.SaveChanges();
            }
        }

        ///<summary>
        ///查询所有招聘信息
        ///<summary>

        public List<Recruitment> GetAllRecruitment()
        {
            using (HotelDBEntities hdb = new HotelDBEntities())
            {
                return (from d in hdb.Recruitment select d).ToList();
            }
         }
     }
}
