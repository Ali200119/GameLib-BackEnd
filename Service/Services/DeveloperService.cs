using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;
using Repository.Repositories.Interfaces;
using Service.Services.Interfaces;

namespace Service.Services
{
	public class DeveloperService: IDeveloperService
	{
        private readonly IDeveloperRepository _developerRepo;

        public DeveloperService(IDeveloperRepository developerRepo)
        {
            _developerRepo = developerRepo;
        }



        public async Task<IEnumerable<Developer>> GetAllAsync() => await _developerRepo.GetAllAsync();

        public async Task<Developer> GetByIdAsync(int? id) => await _developerRepo.GetByIdAsync(id);
    }
}