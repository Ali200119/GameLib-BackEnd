using System;
using System.Threading.Tasks;
using Domain.Models;
using Repository.Repositories.Interfaces;
using Service.Services.Interfaces;

namespace Service.Services
{
	public class AboutService: IAboutService
	{
        private readonly IAboutRepository _aboutRepository;

        public AboutService(IAboutRepository aboutRepository)
        {
            _aboutRepository = aboutRepository;
        }



        public async Task<IEnumerable<About>> GetAsync()
        {
            return await _aboutRepository.GetAllAsync();
        }
    }
}