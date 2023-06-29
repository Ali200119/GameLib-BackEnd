using System;
using Domain.Models;

namespace Service.Services.Interfaces
{
	public interface IDeveloperService
	{
		Task<IEnumerable<Developer>> GetAllAsync();
		Task<Developer> GetByIdAsync(int? id);
	}
}