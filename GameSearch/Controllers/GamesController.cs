using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameSearch.Models;
using GameSearch.ViewModels;
using System.Data.Entity;
using GameSearch.Migrations;

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

        private IEnumerable<Game> GetGames()
            {
            return new List<Game>
            {
                new Game { Id = 1, Name = "Runescape", Genre = "MMORPG"},
                new Game { Id = 2, Name = "CS:GO", Genre = "FPS"}
                    };
            }

        public ViewResult Index()
        {
            var games = GetGames();

            return View(games);
        }
    }
}
