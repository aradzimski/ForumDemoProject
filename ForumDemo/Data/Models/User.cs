using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumDemo.Data.Models
{
    public class User : IdentityUser
    {
        public User ()
        {
            PostCounter = 0;
        }
        public int PostCounter { get; set; }
    }
}
