using System;
using Domain.Models;

namespace Service.Services.Interfaces
{
	public interface IGenreService
	{
		Task<IEnumerable<Genre>> GetAllAsync();
	}
}