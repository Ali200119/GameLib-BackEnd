using System;
using Domain.Models;

namespace Service.Services.Interfaces
{
	public interface IPlatformService
	{
		Task<IEnumerable<Platform>> GetAllAsync();
		Task<IEnumerable<Platform>> GetAllWithIncludesAsync();
	}
}