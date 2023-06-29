﻿using System;
using Domain.Models;
using Repository.Repositories.Interfaces;
using Service.Services.Interfaces;

namespace Service.Services
{
	public class GameService: IGameService
	{
        private readonly IGameRepository _gameRepo;

        public GameService(IGameRepository gameRepo)
        {
            _gameRepo = gameRepo;
        }



        public async Task<IEnumerable<Game>> GetAllWithIncludesAsync() => await _gameRepo.GetAllAsync(g => g.GameImages);

        public async Task<Game> GetByIdWithIncludesAsync(int? id)
        {
            if (id is null) throw new ArgumentNullException();

            return await _gameRepo.GetByIdWithFullDataAsync(id);
        }

        public async Task<IEnumerable<Game>> GetByNameWithIncludesAsync(string searchText)
        {
            if (searchText is null) throw new ArgumentNullException();

            return await _gameRepo.SearchByNameAsync(searchText);
        }
    }
}