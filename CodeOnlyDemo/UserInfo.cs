using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOnlyDemo
{
    public class UserInfo
    {
        public UserInfo()
        {
            OrderInfo =new HashSet<OrderInfo>();
        }

        [Key]
        public int Id { get; set; }

        public string SName { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public virtual ICollection<OrderInfo> OrderInfo { get; set; }
    }
}
