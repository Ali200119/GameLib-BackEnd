using System;
using Domain.Models;

namespace Service.Services.Interfaces
{
	public interface ISocialService
	{
		Task<IEnumerable<Social>> GetAllAsync();
	}
}