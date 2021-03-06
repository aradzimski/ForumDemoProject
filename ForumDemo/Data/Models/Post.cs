using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumDemo.Data.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Contents { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public bool IsEdited { get; set; }

        public virtual User User { get; set; }
        public virtual Topic Topic { get; set; }
    }
}
