using System;
using Domain.Models;

namespace Service.Services.Interfaces
{
	public interface IBlogService
	{
		Task<IEnumerable<Blog>> GetAllWithIncludesAsync();
		Task<Blog> GetByIdAsync(int? id);
	}
}