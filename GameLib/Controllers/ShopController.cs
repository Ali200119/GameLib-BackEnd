using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Service.Services.Interfaces;
using Service.ViewModels;

namespace GameLib.Controllers
{
    public class ShopController : Controller
    {
        private readonly IStaticDataService _staticDataService;
        private readonly IGameService _gameService;
        private readonly IPlatformService _platformService;
        private readonly IGenreService _genreService;
        private readonly ISocialService _socialService;

        public ShopController(IStaticDataService staticDataService,
                              IGameService gameService,
                              IPlatformService platformService,
                              IGenreService genreService,
                              ISocialService socialService)
        {
            _staticDataService = staticDataService;
            _gameService = gameService;
            _platformService = platformService;
            _genreService = genreService;
            _socialService = socialService;
        }



        public async Task<IActionResult> Index()
        {
            Dictionary<string, string> sectionHeaders = _staticDataService.GetAllSectionHeaders();
            IEnumerable<Game> games = await _gameService.GetAllWithIncludesAsync();
            IEnumerable<Platform> platforms = await _platformService.GetAllWithIncludesAsync();
            IEnumerable<Genre> genres = await _genreService.GetAllAsync();
            IEnumerable<Social> socials = await _socialService.GetAllAsync();

            ShopVM model = new ShopVM
            {
                SectionHeaders = sectionHeaders,
                Games = games.OrderBy(g => g.Name),
                Platforms = platforms,
                Genres = genres,
                Socials = socials
            };

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Sort(string pattern)
        {
            try
            {
                if (pattern is null) throw new ArgumentNullException();

                return PartialView("_GamesPartial", await _gameService.Sort(pattern));
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

        [HttpGet]
        public async Task<IActionResult> FilterByPlatform(int? platformId)
        {
            try
            {
                if (platformId is null) throw new ArgumentNullException();

                return PartialView("_GamesPartial", await _platformService.FilterGames(platformId));
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

        [HttpGet]
        public async Task<IActionResult> FilterByGenre(int? genreId)
        {
            try
            {
                if (genreId is null) throw new ArgumentNullException();

                return PartialView("_GamesPartial", await _genreService.FilterGames(genreId));
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