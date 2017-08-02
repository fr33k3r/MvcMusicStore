using MvcMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            var albums = GetAlbums();
            return View(albums);
        }

        // GET: Store/Browse?genre=Disco
        public string Browse(string genre)
        {
            string message =
                HttpUtility.HtmlEncode($"Store.Browse, Genre = {genre}");
            return message;
        }

        // GET: Store/Details/5
        public string Details(int id)
        {
            string message = "Store.Details, ID = " + id;
            return message;
        }

        [Authorize]
        public ActionResult Buy(int id)
        {
            var album = GetAlbums().Single(a => a.AlbumId == id);
            //Charge the user and ship the album!!!
            return View(album);
        }

        // A simple music catalog
        private static List<Album> GetAlbums()
        {
            var albums = new List<Album>{
                new Album { AlbumId = 1, Title = "The Fall of Math", Price = 8.99M},
                new Album { AlbumId = 2, Title = "The Blue Notebooks", Price = 8.99M},
                new Album { AlbumId = 3, Title = "Lost in Translation", Price = 9.99M },
                new Album { AlbumId = 4, Title = "Permutation", Price = 10.99M },
            };
            return albums;
        }
    }
}