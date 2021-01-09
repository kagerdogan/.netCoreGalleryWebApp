using Gallery.Models;
using Gallery.ViewModels;
using GalleryBusiness.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryFront.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly IArtist _artist;
        private readonly IArtWork _artwork;
        private readonly IGroup _group;
        //private readonly IUserLogin _userlogin;

        public HomeController(IArtist artist,IArtWork artwork,IGroup group )
        {
            _artist = artist;
            _artwork = artwork;
            _group = group;
          //  _userlogin = userlogin;
        }

        public IActionResult Index()
        {
          
            return View();
        }

        [HttpPost]
        public void SubmitForm(Artist artist)
        {
            _artist.AddArtist(artist);
        }
        public IActionResult GroupList()
        {
            ViewBag.artworkobj = _artwork.ArtworkNameView();

            return View(_group.ListOfGroup());
        }
        public IActionResult GetallArtist()
        {
            return View(_artist.GetAllArtists());
        }
       public IActionResult ListOfArtWorks()
        {
            return View(_artwork.ListOfArtWork());
        }
       public IActionResult Edit(int id)
        {
            ViewBag.artistobj = _artist.ArtistNameView();
            return View(_artwork.FindArtWorkByID(id));
        }
        [HttpPost]
        public IActionResult Edit(ArtWork eartwork)
        {
            _artwork.SetArtWork(eartwork);
            return RedirectToAction("ListOfArtWorks");
        }
        public IActionResult AddArtWork()
        {
            ViewBag.artistobj = _artist.ArtistNameView();
            return View();
        }
        [HttpPost]
        public void AddArtWork(ArtWork artwork)
        {
            _artwork.AddArtWork(artwork);
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DeleteArtWork(int id)
        {
            _artwork.DeleteArtWork(id);
            return RedirectToAction("ListOfArtWorks");
        }
        public IActionResult EditArtist(int id)
        {
            return View(_artist.FindArtistByID(id));
        }
        [HttpPost]
        public IActionResult EditArtist(Artist eartist)
        {
            _artist.SetArtist(eartist);
            return RedirectToAction("GetallArtist");
        }
        [HttpPost]
        public IActionResult DeleteArtist(int id)
        {
            _artist.DeleteArtist(id);
            return RedirectToAction("GetallArtist");
        }
        public void AddGroup(Group group)
        {
            _group.AddGroup(group);
        }
        public IActionResult DeleteGroup(int id)
        {
            _group.DeleteGroup(id);
            return RedirectToAction("GroupList");
        }
        [HttpPost]
        public IActionResult EditGroup(Group egroup)
        {
            _group.SetGroup(egroup);
            return RedirectToAction("GroupList");
        }
        
        public IActionResult EditGroup(int id)
        {
            return View(_group.FindGroupById(id));
        }
    }
}
