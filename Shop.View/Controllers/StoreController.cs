﻿using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ViewResult Index()
        {
            ViewBag.CurrentTime = DateTime.Now;
            ViewBag.Albums = CreateAlbums();
            string e = "22";
            return View(CreateAlbums());
        }

        public ActionResult Browse()
        {
            return View();
        }

        public string Details(string id)
        {
            return "Hello from Store.Details()"+id;
        }

        private List<Album> CreateAlbums()
        {
            var albums = new List<Album>();
            for (int i = 0; i < 10; i++)
            {
                albums.Add(new Album { Title="Album"+i});
            }
            return albums;
        }
    }
}