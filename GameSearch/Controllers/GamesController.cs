using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameSearch.Models;
using GameSearch.ViewModels;

namespace GameSearch.Controllers
{
    public class GamesController : Controller
    {
        // GET: Games
        public ViewResult Index()
        {
            var games = GetGames();
            return View(games);
        }

        private IEnumerable<Game> GetGames()
        {
            return new List<Game>
            {
                new Game {Id = 1, Name = "Oldschool Runescape"},
                new Game {Id = 2, Name = "Runescape 3"}
            };
        }
    }
}