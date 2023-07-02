using System;
using System.Threading.Tasks;
using Domain.Models;
using Repository.Repositories.Interfaces;
using Service.Services.Interfaces;

namespace Service.Services
{
	public class ContactService: IContactService
	{
        private readonly IContactRepository _contactRepo;

        public ContactService(IContactRepository contactRepo)
        {
            _contactRepo = contactRepo;
        }



        public async Task CreateAsync(Contact contact)
        {
            if (contact is null) throw new ArgumentNullException();

            await _contactRepo.CreateAsync(contact);
        }
    }
}