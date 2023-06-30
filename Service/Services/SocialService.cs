using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;
using Repository.Repositories.Interfaces;
using Service.Services.Interfaces;

namespace Service.Services
{
	public class SocialService: ISocialService
	{
        private readonly ISocialRepository _socialRepo;

        public SocialService(ISocialRepository socialRepo)
        {
            _socialRepo = socialRepo;
        }



        public async Task<IEnumerable<Social>> GetAllAsync() => await _socialRepo.GetAllAsync();
    }
}