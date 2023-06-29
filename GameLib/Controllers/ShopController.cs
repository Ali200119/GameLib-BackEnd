using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Service.Services.Interfaces;
using Service.ViewModels.Shop;

namespace GameLib.Controllers
{
    public class ShopController : Controller
    {
        private readonly IStaticDataService _staticDataService;
        private readonly IGameService _gameService;

        public ShopController(IStaticDataService staticDataService,
                              IGameService gameService)
        {
            _staticDataService = staticDataService;
            _gameService = gameService;
        }



        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            try
            {
                if (id is null) throw new ArgumentNullException();

                Game game = await _gameService.GetByIdWithIncludesAsync(id);

                if (game is null) throw new NullReferenceException();

                ViewBag.Platforms = await GetPlatformsAsync((int)id);
                Dictionary<string, string> sectionHeaders = _staticDataService.GetAllSectionHeaders();

                GameDetailsVM model = new GameDetailsVM
                {
                    SectionHeaders = sectionHeaders,
                    Game = game
                };

                return View(model);
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


        private async Task<SelectList> GetPlatformsAsync(int id)
        {
            Game game = await _gameService.GetByIdWithIncludesAsync(id);

            return new SelectList(game.GamePlatforms.Select(gm => gm.Platform), "Id", "Name");
        }
    }
}