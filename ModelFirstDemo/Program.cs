using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //EF 
            //创建上下文
            DataModelContainer dbContext = new DataModelContainer();

            #region 添加
            ////创建一个用户顺便定义两个订单
            //UserInfo userInfo = new UserInfo();
            //userInfo.UName = "yang";

            ////告诉上下文我们对这个实体做添加操作
            //dbContext.UserInfo.Add(userInfo);

            ////添加两个订单
            //OrderInfo order1 = new OrderInfo();
            //order1.Content = "shit1";
            //dbContext.OrderInfo.Add(order1);

            //OrderInfo order2 = new OrderInfo();
            //order2.Content = "shit2";
            //dbContext.OrderInfo.Add(order2);

            ////关联三个实体
            ////1、通过用户添加订单实体到自己的导航属性
            //userInfo.OrderInfo.Add(order1);
            ////2、通过订单指定用户实体
            //order2.UserInfo = userInfo;
            ////order2.UserInfoID = userInfo.ID; 
            #endregion
            //ee
            #region 修改

            //UserInfo userInfoEdit =new UserInfo();
            //userInfoEdit.ID = 1;
            //userInfoEdit.UName = "Demo" + DateTime.Now;

            //dbContext.Entry(userInfoEdit).State = EntityState.Modified;
            //dbContext.Entry(userInfoEdit).Property(u => u.UName).IsModified = true;


            #endregion

            //dbContext.SaveChanges();//才是真正的把上面的实体的变化封装成sql执行到数据库里面去。


            #region 查询

            ////IQueryable<UserInfo>  VS  List、Arrary、Dic、HaseSet....

            //IQueryable<UserInfo> temp = from u in dbContext.UserInfo.Include("OrderInfo")
            //                            //where  u.UName.Contains("o") 
            //                            //&& u.UName.StartsWith("D")
            //                            select u;
            //两种延迟加载
            #region 第一种延迟加载 用到的时候就会去查询数据。
            //用到的时候就会去查询数据。
            //foreach (var userInfo in temp)
            //{
            //    Console.WriteLine(userInfo.ID + "  " +userInfo.UName);
            //}

            //foreach (var userInfo in temp)
            //{
            //    Console.WriteLine(userInfo.ID + "  " + userInfo.UName);
            //}

            //var temp2 = from u in temp
            //            where u.ID > 0
            //            select u;
            //foreach (var userInfo in temp2)
            //{
            //    Console.WriteLine(userInfo.ID + "  " + userInfo.UName);
            //} 
            #endregion

            #region 第二种延迟加载

            //情景1：用户表跟订单表数据都是10000 0000条    进行连接查询的时候：过滤数据实际是多少条？
            //使用延迟加载
            //情景2：数据量小的时候，减少查询次数提高效率。

            //foreach (var userInfo in temp)//100个用户数据。    101：跟后台交互的时间就比 一次连接表查询时间还要长。
            //{
            //    foreach (var orderInfo in userInfo.OrderInfo)
            //    {
            //        Console.WriteLine(userInfo.UName+ "  " +orderInfo.ID + "  " + orderInfo.Content);
            //    }
            //}
            #endregion

          


            #endregion


            #region lambda 查询

            //linq 和 lambda性能有什么不同？
            //运行阶段都是一样的。
            //linq →Expression
            //lambda→Expression

            //var data = dbContext.UserInfo.Where(u => u.ID > 0);

            //foreach (var userInfo in data)
            //{
            //    Console.WriteLine(userInfo.ID + "  " + userInfo.UName);
            //}

            #endregion


            #region 分页

            //var pageData = dbContext.UserInfo
            //                        .Where(u => u.ID > 0)
            //                        //.OrderBy(u=>u.ID)//升序
            //                        .OrderByDescending(u => u.ID)
            //                        //一页5条    取 3页
            //                        .Skip(5*(3 - 1))
            //                        .Take(5);

            //foreach (var userInfo in pageData)
            //{
                
            //}


            #endregion

            #region 查询部分列的数据

            //var demo = (from u in dbContext.UserInfo
            //            where u.ID > 0
            //            orderby u.ID descending
            //            select u).Skip(10).Take(5);


            //var data = from u in dbContext.UserInfo
            //           select new {MyUName=u.UName,u.ID,OrderCounts= u.OrderInfo.Count};

            var data =
                dbContext.UserInfo.Where(u => u.ID > 0)
                         .Select(u => new {u.ID, MyUName = u.UName, OrderCounts = u.OrderInfo.Count});



            foreach (var item in data)
            {
                //Console.WriteLine(VARIABLE);
                Console.WriteLine(item.ID + "  " + item.MyUName + "  " + item.OrderCounts);
            }

            #endregion

            Console.WriteLine("ok..");
            Console.ReadKey();
        }
    }
}
