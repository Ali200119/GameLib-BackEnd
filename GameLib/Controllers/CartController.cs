using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Services.Interfaces;
using Service.ViewModels;

namespace GameLib.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly ICartService _cartService;
        private readonly IGameService _gameService;

        public CartController(ICartService cartService,
                              IGameService gameService)
        {
            _cartService = cartService;
            _gameService = gameService;
        }



        public async Task<IActionResult> Index(string userId)
        {
            try
            {
                if (userId is null) throw new ArgumentNullException();

                Cart cart = await _cartService.GetUserCartAsync(userId);

                if (cart is null) throw new NullReferenceException();

                return View(cart);
            }

            catch (ArgumentNullException)
            {
                return BadRequest();
            }

            catch(NullReferenceException)
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> RemoveGameFromCart(int? gameId, string userId)
        {
            try
            {
                if (gameId is null || userId is null) throw new ArgumentNullException();

                await _cartService.RemoveFromCartAsync(gameId, userId);

                return Ok();
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

        [HttpPost]
        public async Task<IActionResult> IncreaseGameCount(int? gameId, string userId)
        {
            try
            {
                if (gameId is null || userId is null) throw new ArgumentNullException();

                await _cartService.IncreaseGameCountAsync(gameId, userId);

                return Ok();
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

        [HttpPost]
        public async Task<IActionResult> DecreaseGameCount(int? gameId, string userId)
        {
            try
            {
                if (gameId is null || userId is null) throw new ArgumentNullException();

                await _cartService.DecreaseGameCountAsync(gameId, userId);

                return Ok();
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

        [HttpPost]
        public async Task<IActionResult> ClearCart(string userId)
        {
            try
            {
                if(userId is null) throw new ArgumentNullException();

                await _cartService.ClearCartAsync(userId);

                return Ok();
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