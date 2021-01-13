using GalleryBusiness.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Gallery.Models;
using System.Linq;
using Gallery.ViewModels;
using System.Security.Cryptography;
using GalleryBusiness.Encrypt;

namespace GalleryBusiness.Core
{
    public class CUserLogin : IUserLogin
    {
        private GalleryContext gc = new GalleryContext();
        public bool Register(UserLoginModel userloginmodel)
        {
            UserLogin ulogin = new UserLogin()
            {
                Username = userloginmodel.UName,
                Password =Sha256.ComputeSha256Hash(userloginmodel.Password)
            };
            UserInformation uInfo = new UserInformation()
            {
                Uage = userloginmodel.Uage,
                Uname = userloginmodel.Name,
                Umail = userloginmodel.Umail,
                Uprofession = userloginmodel.Uprofession,
                Urole="admin"
            };
            uInfo.UserLogin = ulogin;
            gc.UserInformations.Add(uInfo);
            gc.SaveChanges();
            return true;
        }
  
    }

}

