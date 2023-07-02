using System;
using Domain.Models;

namespace Service.Services.Interfaces
{
	public interface IBlogService
	{
		Task<IEnumerable<Blog>> GetAllWithIncludesAsync();
		Task<Blog> GetByIdWithIncludesAsync(int? id);
		Task<IEnumerable<Blog>> GetPaginatedDatasAsync(int page, int take);
		Task<int> GetCountAsync();
    }
}