using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameSearch.Models;
using GameSearch.ViewModels;
using System.Data.Entity;

namespace GameSearch.Controllers
{
    public class GamesController : Controller
    {
        private ApplicationDbContext _context;

        public GamesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var games = _context.Games.ToList();

            return View(games);
        }

        /*public ActionResult Details(int id)
        {
            var game = _context.Games.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (game == null)
                return HttpNotFound();

            return View(game);

        }*/



    }
}