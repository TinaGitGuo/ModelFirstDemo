using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOnlyDemo
{
    public class OrderInfo
    {
        [Key]
        public int Id { get; set; }

        public string Content { get; set; }

        public virtual  UserInfo UserInfo { get; set; }
    }
}
