using System;
using Domain.Models;

namespace Service.Services.Interfaces
{
	public interface IContactService
	{
		Task CreateAsync(Contact contact);
	}
}