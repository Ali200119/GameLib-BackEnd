using System;
using Domain.Models;

namespace Service.Services.Interfaces
{
	public interface IBlogImageService
	{
		Task<IEnumerable<BlogImage>> GetAllByBlogIdAsync(int? id);
		Task CreateMultipleAsync(List<BlogImage> blogImages);
        Task DeleteAsync(BlogImage blogImage);
	}
}