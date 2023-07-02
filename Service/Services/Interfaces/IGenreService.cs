using System;
using Domain.Models;

namespace Service.Services.Interfaces
{
	public interface IGenreService
	{
		Task<IEnumerable<Genre>> GetAllAsync();
		Task<IEnumerable<Game>> FilterGames(int? id);
    }
}