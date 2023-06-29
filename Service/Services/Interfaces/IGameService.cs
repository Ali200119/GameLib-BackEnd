using System;
using Domain.Models;

namespace Service.Services.Interfaces
{
	public interface IGameService
	{
		Task<IEnumerable<Game>> GetAllWithIncludesAsync();
		Task<Game> GetByIdWithIncludesAsync(int? id);
		Task<IEnumerable<Game>> GetByNameWithIncludesAsync(string searchText);
    }
}