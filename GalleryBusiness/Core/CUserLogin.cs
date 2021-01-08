using GalleryBusiness.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Gallery.Models;
using System.Linq;

namespace GalleryBusiness.Core
{
    public class CUserLogin : IUserLogin
    {
        private GalleryContext gc = new GalleryContext();
        public bool Register(UserLogin userlogin)
        {
            gc.Add(userlogin);
            gc.SaveChanges();
            return true;
        }
    }
}
