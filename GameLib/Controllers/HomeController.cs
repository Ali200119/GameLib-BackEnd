using System.Diagnostics;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Services.Interfaces;
using Service.ViewModels.Home;

namespace GameLib.Controllers;

public class HomeController : Controller
{
    private readonly IStaticDataService _staticDataService;
    private readonly IGameService _gameService;
    private readonly IBlogService _blogService;
    private readonly IAdvantageService _advantageService;
    private readonly IDeveloperService _developerService;

    public HomeController(IStaticDataService staticDataService,
                          IGameService gameService,
                          IBlogService blogService,
                          IAdvantageService advantageService,
                          IDeveloperService developerService)
    {
        _staticDataService = staticDataService;
        _gameService = gameService;
        _blogService = blogService;
        _advantageService = advantageService;
        _developerService = developerService;
    }



    public async Task<IActionResult> Index()
    {
        try
        {
            Dictionary<string, string> sectionHeaders = _staticDataService.GetAllSectionHeaders();
            IEnumerable<Game> games = await _gameService.GetAllWithIncludesAsync();
            IEnumerable<Blog> blogs = await _blogService.GetAllWithIncludesAsync();
            IEnumerable<Advantage> advantages = await _advantageService.GetAllAsync();
            IEnumerable<Developer> developers = await _developerService.GetAllAsync();

            HomeVM model = new HomeVM
            {
                SectionHeaders = sectionHeaders,
                Games = games,
                Blogs = blogs,
                Advantages = advantages,
                Developers = developers
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
}