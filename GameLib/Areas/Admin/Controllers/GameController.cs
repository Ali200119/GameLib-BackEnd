using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using GameLib.Areas.Admin.ViewModels.Blog;
using GameLib.Areas.Admin.ViewModels.Game;
using GameLib.Helpers.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Service.Helpers;
using Service.Services.Interfaces;

namespace GameLib.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class GameController : Controller
    {
        private readonly IGameService _gameService;
        private readonly IWebHostEnvironment _env;
        private readonly IPlatformService _platformService;
        private readonly IGenreService _genreService;

        public GameController(IGameService gameService,
                              IWebHostEnvironment env,
                              IPlatformService platformService,
                              IGenreService genreService)
        {
            _gameService = gameService;
            _env = env;
            _platformService = platformService;
            _genreService = genreService;
        }



        public async Task<IActionResult> Index()
        {
            IEnumerable<Game> games = await _gameService.GetAllWithIncludesAsync();

            List<GameListVM> model = new List<GameListVM>();

            foreach (var game in games)
            {
                model.Add(new GameListVM
                {
                    Id = game.Id,
                    MainImage = game.GameImages.FirstOrDefault(gi => gi.IsMain).Name,
                    Name = game.Name,
                    Developer = game.Developer
                });
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Platforms = await GetPlatformsAsync();
            ViewBag.Genres = await GetGenresAsync();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(GameCreateVM model)
        {
            ViewBag.Platforms = await GetPlatformsAsync();
            ViewBag.Genres = await GetGenresAsync();

            if (!ModelState.IsValid) return View(model);

            foreach (var photo in model.Photos)
            {
                if (!photo.CheckFileType("image/"))
                {
                    ModelState.AddModelError("Photos", "File type must be image.");
                    return View(model);
                }
            }

            IEnumerable<Game> games = await _gameService.GetAllWithIncludesAsync();

            List<GameImage> gameImages = new List<GameImage>();

            foreach (var photo in model.Photos)
            {
                string fileName = photo.GenerateFileName();
                string path = FileHelper.GetFilePath(_env.WebRootPath, "assets/img/games", fileName);

                await photo.CreateLocalFileAsync(path);

                GameImage gameImage = new GameImage
                {
                    Name = fileName
                };

                gameImages.Add(gameImage);
            }

            List<GamePlatform> gamePlatforms = new List<GamePlatform>();

            foreach (var gamePlatformId in model.GamePlatformIdies)
            {
                gamePlatforms.Add(new GamePlatform
                {
                    PlatformId = gamePlatformId
                });
            }

            List<GameGenre> gameGenres = new List<GameGenre>();

            foreach (var gameGenreId in model.GameGenreIdies)
            {
                gameGenres.Add(new GameGenre
                {
                    GenreId = gameGenreId
                });
            }

            gameImages.FirstOrDefault().IsMain = true;

            if (model.FavGame) games.FirstOrDefault(b => b.FavGame).FavGame = false;

            decimal convertedPrice = decimal.Parse(model.Price.Replace(",", "."));

            Game newGame = new Game
            {
                Name = model.Name,
                Price = convertedPrice,
                Description = model.Description,
                Developer = model.Developer,
                Publisher = model.Publisher,
                FavGame = model.FavGame,
                ForPlaySation = model.ForPlayStation,
                ForXbox = model.ForXbox,
                ForPC = model.ForPC,
                ReleaseDate = model.ReleaseDate,
                Trailer = model.Trailer,
                GameImages = gameImages,
                GamePlatforms = gamePlatforms,
                GameGenres = gameGenres
            };

            await _gameService.CreateAsync(newGame);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id is null) throw new ArgumentNullException();

            Blog blog = await _blogService.GetByIdWithIncludesAsync(id);

            if (blog is null) throw new NullReferenceException();


            List<string> images = new List<string>();

            foreach (var image in blog.BlogImages)
            {
                images.Add(image.Name);
            }


            BlogDetailsVM model = new BlogDetailsVM
            {
                Title = blog.Title,
                Game = blog.Game,
                ShortDescription = blog.ShortDescription,
                Description = blog.Description,
                BlogAuthor = blog.BlogAuthor.Name,
                FavBlog = blog.FavBlog,
                Images = images,
                CreatedAt = blog.CreatedAt,
                ModifiedAt = blog.ModifiedAt
            };

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.Platforms = await GetPlatformsAsync();
            ViewBag.Genres = await GetGenresAsync();

            if (id is null) throw new ArgumentNullException();

            Blog blog = await _blogService.GetByIdWithIncludesAsync(id);

            if (blog is null) throw new NullReferenceException();

            List<string> images = new List<string>();

            foreach (var image in blog.BlogImages)
            {
                images.Add(image.Name);
            }

            BlogEditVM model = new BlogEditVM
            {
                Id = blog.Id,
                Title = blog.Title,
                Game = blog.Game,
                ShortDescription = blog.ShortDescription,
                Description = blog.Description,
                BlogAuthorId = blog.BlogAuthorId,
                FavBlog = blog.FavBlog,
                Images = images
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(BlogEditVM model)
        {
            ViewBag.Platforms = await GetPlatformsAsync();
            ViewBag.Genres = await GetGenresAsync();

            Blog blog = await _blogService.GetByIdWithIncludesAsync(model.Id);

            if (blog is null) throw new NullReferenceException();

            List<string> images = new List<string>();

            foreach (var image in blog.BlogImages)
            {
                images.Add(image.Name);
            }

            model.Images = images;

            if (!ModelState.IsValid) return View(model);

            List<BlogImage> blogImages = new List<BlogImage>();

            if (model.Photos is null)
            {
                foreach (var image in blog.BlogImages)
                {
                    blogImages.Add(image);
                }
            }

            else
            {
                foreach (var photo in model.Photos)
                {
                    if (!photo.CheckFileType("image/"))
                    {
                        ModelState.AddModelError("Photos", "File type must be image.");
                        return View(model);
                    }
                }

                foreach (var photo in model.Photos)
                {
                    string fileName = photo.GenerateFileName();
                    string path = FileHelper.GetFilePath(_env.WebRootPath, "assets/img/blog", fileName);

                    await photo.CreateLocalFileAsync(path);

                    BlogImage blogImage = new BlogImage
                    {
                        BlogId = model.Id,
                        Name = fileName
                    };

                    blogImages.Add(blogImage);
                }

                blogImages.FirstOrDefault().IsMain = true;
            }

            IEnumerable<BlogImage> dbBlogImages = await _blogImageService.GetAllByBlogIdAsync(model.Id);

            foreach (var image in dbBlogImages)
            {
                string oldPathImage = FileHelper.GetFilePath(_env.WebRootPath, "assets/img/blog", image.Name);

                FileHelper.DeleteFileFromPath(oldPathImage);

                await _blogImageService.DeleteAsync(image);
            }

            await _blogImageService.CreateMultipleAsync(blogImages);

            Blog updatedBlog = new Blog
            {
                Id = model.Id,
                Title = model.Title,
                Game = model.Game,
                ShortDescription = model.ShortDescription,
                Description = model.Description,
                FavBlog = model.FavBlog,
                BlogAuthorId = model.BlogAuthorId,
                CreatedAt = blog.CreatedAt,
                ModifiedAt = DateTime.Now
            };

            await _blogService.UpdateAsync(updatedBlog);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null) throw new ArgumentNullException();

            Blog blog = await _blogService.GetByIdWithIncludesAsync(id);

            if (blog is null) throw new NullReferenceException();

            foreach (var image in blog.BlogImages)
            {
                string path = FileHelper.GetFilePath(_env.WebRootPath, "assets/img/blog", image.Name);

                FileHelper.DeleteFileFromPath(path);
            }

            await _blogService.DeleteAsync(blog);

            return RedirectToAction(nameof(Index));
        }



        private async Task<SelectList> GetPlatformsAsync()
        {
            IEnumerable<Platform> platforms = await _platformService.GetAllAsync();

            return new SelectList(platforms, "Id", "Name");
        }

        private async Task<SelectList> GetGenresAsync()
        {
            IEnumerable<Genre> genres = await _genreService.GetAllAsync();

            return new SelectList(genres, "Id", "Name");
        }
    }
}

