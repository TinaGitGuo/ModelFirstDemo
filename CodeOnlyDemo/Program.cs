using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOnlyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CodeFirstDbContext dbContext = new CodeFirstDbContext())
            {
                dbContext.Database.CreateIfNotExists();

                UserInfo userInfo = new UserInfo();
                userInfo.Age = 10;
                userInfo.Email = "ssss";
                userInfo.SName = "ssss";

                dbContext.UserInfo.Add(userInfo);
                dbContext.SaveChanges();
            }
            Console.WriteLine("ok....");

            Console.ReadKey();

        }
    }
}
