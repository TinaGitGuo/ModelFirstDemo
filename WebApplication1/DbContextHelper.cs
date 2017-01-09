using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace WebApplication1
{
    public class DbContextHelper
    {
        //保证一次请求共用一个上下文实例
        public static MyDbContext GetCurrentDbContext()
        {
            #region HttpContext 方式
            ////HttpContext:一次请求，HttpContext已经保证只有一个实例。
            //MyDbContext dbContext = HttpContext.Current.Items["MyDbContext"] as MyDbContext;

            //if (dbContext == null)//当前Http上下文不存在当前对象
            //{
            //    dbContext =new MyDbContext();
            //    HttpContext.Current.Items.Add("MyDbContext",dbContext);
            //}
            //return dbContext; 
            #endregion

            #region CallContext

            //一个线程共用一个上下文实例。一次请求就用一个线程。

            MyDbContext dbContext = CallContext.GetData("DbContext") as MyDbContext;
            
            if (dbContext == null)
            {
                dbContext =new MyDbContext();
                CallContext.SetData("DbContext",dbContext);
            }

            return dbContext;

            #endregion
        }
    }
    public class MyDbContext
    {
        
    }
}