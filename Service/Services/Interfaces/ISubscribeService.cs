using System;
namespace Service.Services.Interfaces
{
	public interface ISubscribeService
	{
		Task<bool> Subscribe(string email);
	}
}