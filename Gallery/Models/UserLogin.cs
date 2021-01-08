using System;
using System.Collections.Generic;

#nullable disable

namespace Gallery.Models
{
    public partial class UserLogin
    {
        public int LoginId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
