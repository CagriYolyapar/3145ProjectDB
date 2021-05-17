using Project.DAL.ContextClasses;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.StrategyPattern
{
    //Bogus Kütüphanesi bize hazır Data sunacaktır...
    public  class MyInit:CreateDatabaseIfNotExists<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            #region Admin


            AppUser au = new AppUser();
            au.UserName = "cgr";
            



            #endregion
        }
    }
}
