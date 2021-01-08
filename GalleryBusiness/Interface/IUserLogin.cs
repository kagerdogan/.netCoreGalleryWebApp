using System;
using System.Collections.Generic;
using System.Text;
using Gallery.Models;

namespace GalleryBusiness.Interface
{
    public interface IUserLogin
    {
        public bool Register(UserLogin userlogin);
    }
}
