using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumDemo.Data.Models
{
    public class Forum
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string UrlTitle { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public virtual IEnumerable<Topic> Topics { get; set; }
    }
}
