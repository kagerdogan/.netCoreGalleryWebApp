using System;
using System.Collections.Generic;
using System.Text;
using Gallery.Models;
using Gallery.ViewModels;

namespace GalleryBusiness.Interface
{
    public interface IUserLogin
    {
        public bool Register(UserLoginModel userloginModel);
        public bool CheckPass(LoginModel Loginmodel);
        public bool isAdmin(string userName);
    }
}
