using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOnly_Demo
{
    public class Publisher
    {
        [Key]
        public string PublisherId { get; set; }
        public string PublisherName { get; set; }
        public DateTime PublishingYear { get; set; }

        public virtual BookMaster BookMaster { get; set; }
    }
}
