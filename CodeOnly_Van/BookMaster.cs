using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeOnly_Van
{
    public class BookMaster
    {
        public BookMaster()
        {
            Publisher = new HashSet<Publisher>();
        }
        public string strBookTypeId { get; set; }
        public string strAccessionId { get; set; }
        public string PublisherId { get; set; }

        public virtual ICollection<Publisher> Publisher { get; set; }
    }

}
