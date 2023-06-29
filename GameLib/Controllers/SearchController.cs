using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Services.Interfaces;

namespace GameLib.Controllers
{
    public class SearchController : Controller
    {
        private readonly IGameService _gameService;

        public SearchController(IGameService gameService)
        {
            _gameService = gameService;
        }



        [HttpGet]
        public async Task<IActionResult> SearchByGames(string searchText)
        {
            try
            {
                if (searchText is null) throw new ArgumentNullException();

                IEnumerable<Game> games = await _gameService.GetByNameWithIncludesAsync(searchText);

                ViewBag.SearchText = searchText;

                return View(games);
            }

            catch (ArgumentNullException)
            {
                return BadRequest();
            }

            catch (NullReferenceException)
            {
                return NotFound();
            }
        }
    }
}