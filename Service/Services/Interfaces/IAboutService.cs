using System;
using Domain.Models;

namespace Service.Services.Interfaces
{
	public interface IAboutService
	{
		Task<IEnumerable<About>> GetAsync();
	}
}