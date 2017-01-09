using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOnly_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CodeFirstDbContext dbContext = new CodeFirstDbContext())
            {
                dbContext.Database.CreateIfNotExists();

                BookMaster book = new BookMaster();
                book.strBookTypeId = "科学类";
                book.strAccessionId = "2017年入册";
                //book.PublisherId = "1";

                dbContext.UserInfo.Add(book);
                dbContext.SaveChanges();
            }
            Console.WriteLine("ok....");
            Console.ReadKey();

        }
    }
}
