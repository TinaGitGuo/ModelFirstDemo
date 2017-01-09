using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOnly_Demo
{
    public class BookMaster
    {
        public BookMaster()
        {
            Publisher = new HashSet<Publisher>();
        }
        [Key]
        public int Id { get; set; }
        public string strBookTypeId { get; set; }
        public string strAccessionId { get; set; }
        //public string PublisherId { get; set; }

        public virtual ICollection<Publisher> Publisher { get; set; }
    }

}
