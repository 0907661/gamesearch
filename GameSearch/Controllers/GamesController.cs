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
        public ActionResult Random()
        {
            var game = new Game() { Name = "RuneScape" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Jimmy"},
                new Customer {Name = "Danny"}
            };

            var viewModel = new RandomGameViewModel
            {
                Game = game,
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("games/released/{month:regex(\\d{2}):range(1,12)}/{year:regex(\\d{4})}")]
        public ActionResult ByReleaseDate(int month, int year)
        {
            return Content(month + "/" + year);
        }
    }
}