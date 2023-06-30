using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;
using Repository.Repositories.Interfaces;
using Service.Services.Interfaces;

namespace Service.Services
{
	public class PlatformService: IPlatformService
	{
        private readonly IPlatformRepository _platformRepo;

        public PlatformService(IPlatformRepository platformRepo)
        {
            _platformRepo = platformRepo;
        }



        public async Task<IEnumerable<Platform>> GetAllAsync() => await _platformRepo.GetAllAsync();

        public async Task<IEnumerable<Platform>> GetAllWithIncludesAsync() => await _platformRepo.GetAllWithFullDataAsync();
    }
}