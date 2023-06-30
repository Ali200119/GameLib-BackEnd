using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Services.Interfaces;
using Service.ViewModels;

namespace GameLib.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly IStaticDataService _staticDataService;
        private readonly ISocialService _socialService;

        public BlogController(IBlogService blogService,
                              IStaticDataService staticDataService,
                              ISocialService socialService)
        {
            _blogService = blogService;
            _staticDataService = staticDataService;
            _socialService = socialService;
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

                Dictionary<string, string> sectionHeaders = _staticDataService.GetAllSectionHeaders();
                Blog blog = await _blogService.GetByIdWithIncludesAsync(id);
                IEnumerable<Blog> latestBlogs = await _blogService.GetAllWithIncludesAsync();
                IEnumerable<Social> socials = await _socialService.GetAllAsync();

                BlogDetailsVM model = new BlogDetailsVM
                {
                    SectionHeaders = sectionHeaders,
                    Blog = blog,
                    LatestBlogs = latestBlogs.OrderByDescending(b => b.CreatedAt).Take(5),
                    Socials = socials
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
}