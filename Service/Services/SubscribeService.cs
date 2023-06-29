using System;
using System.Threading.Tasks;
using Domain.Models;
using Repository.Repositories.Interfaces;
using Service.Services.Interfaces;

namespace Service.Services
{
	public class SubscribeService: ISubscribeService
	{
        private readonly ISubscribeRepository _subscribeRepo;

        public SubscribeService(ISubscribeRepository subscribeRepo)
        {
            _subscribeRepo = subscribeRepo;
        }



        public async Task<bool> Subscribe(string email)
        {
            if (email is null) throw new ArgumentNullException();

            bool isEmailExists = await _subscribeRepo.CheckIfEmailExistsAsync(email);

            if (!isEmailExists)
            {
                Subscribe subscribe = new Subscribe
                {
                    Email = email
                };

                await _subscribeRepo.CreateAsync(subscribe);

                return true;
            }

            return false;
        }
    }
}