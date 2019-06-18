using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;
using BLL;
namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsBLL newbll = new NewsBLL();
            var  catetory = newbll.GetNewsCategory();
            foreach (var item in catetory)
            {
                Console.WriteLine( item.CategoryId+"\t"+item.CategoryName);
            }
            Console.ReadKey();
        }
    }
}
