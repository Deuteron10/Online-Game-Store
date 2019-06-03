using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Online_Game_Store.Models; //importing Model 
//using Online_Game_Store.ViewModels;

namespace Online_Game_Store.Controllers
{
    public class GameController : Controller
    {
        private IEnumerable<Game> GetGames()
        {
            return new List<Game>
            {
                new Game { ID = 1, Name = "Shrek" },
                new Game { ID = 2, Name = "Wall-e" }
            };
        }

        public ViewResult Index()
        {
            var games = GetGames();

            return View(games);
        }

        /*public ActionResult Index(int? PageIndex, string SortBy)
        {
            // Null PageIndex's default value will be 1 
             if (!PageIndex.HasValue)
                 PageIndex = 1;

             // Null SortBy's default value will be "Name"
             if (String.IsNullOrWhiteSpace(SortBy))
                 SortBy = "Name"; 

             var games = new List<Game> 
             {
                 new Game {Name = "Grand Theft Auto V" },
                 new Game {Name = "Grand Theft Auto IV" }
             };

             var gameIndexViewModel = new RandomGameViewModel
             {
                 Games = games
             };

             return View(gameIndexViewModel);

             //return Content(String.Format("Page Index is {0} & Sorted By {1}", PageIndex,SortBy));

             // url "/Game will display Page Index is 1 and sorted by Name since no values are passed
             // url "/Game?PageIndex=25&SortBy=Date" will display Page Index is 25 and sorted by Date
         } */

        // GET: Game/Random
       /* public ActionResult Random()
        {
            //var game = new Game(){ Name = "Grand Theft Auto V" };//"Name" property of model "Game" is used

            var customers = new List<Customer>
            {
                new Customer { Name = "John Doe" },  // 2 customers created from customer class
                new Customer { Name = "Jane Doe" }
            };

            var ViewModel = new RandomGameViewModel
            {
                //Game = game,
                Customerss = customers
            };

            return View(ViewModel);

            // Different types of ActionResults

            
            //return View(game); // returns game view
            //return Content("Hello World"); // Display Content 
            //return HttpNotFound(); // Display 404
            //return new EmptyResult(); // Display nothing
            //return RedirectToAction("Index", "Home"); // Redirect to "action" of particular "Controller"
        } */

        // GET: Game/Edit/10  or Game/Edit?ID=10
        public ActionResult Edit(int ID)
        {
            return Content("ID = " + ID);
        }

        /* // GET: Game/Edit?GameID=10 will work
         // GET: Game/Edited/10  will not work since default in RouterConfig.cs is {id} i.e. url: "{controller}/{action}/{id}"
         public ActionResult Edited(int GameID)
         {
             return Content("Movie ID = " + GameID);
         }

         */

        // List of games. Index() will be default method/action in this controller
        // Display games on the page using PageIndex and SortBy will sort them
        // ? is addded to make PageIndex nullable and string can be nullable by default in this method.
        // This will elminate the need of passing parameters while accessing this controller's method via url



        // Setting Attribute for this action's routing
        // Also applying constraing such as an year should be 4 digits and month should be b/w 1 to 12
        [Route("game/released/{year:regex(\\d{4})}/{month:range(1, 12)}")]

        // Display games according to release year and month
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}