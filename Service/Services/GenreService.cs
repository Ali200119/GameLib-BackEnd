using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;
using Repository.Repositories.Interfaces;
using Service.Services.Interfaces;

namespace Service.Services
{
	public class GenreService: IGenreService
	{
		private readonly IGenreRepository _genreRepo;

        public GenreService(IGenreRepository genreRepo)
        {
            _genreRepo = genreRepo;
        }



        public async Task<IEnumerable<Genre>> GetAllAsync() => await _genreRepo.GetAllAsync();
    }
}