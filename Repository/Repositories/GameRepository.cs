using System;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Repositories.Interfaces;

namespace Repository.Repositories
{
    public class GameRepository : Repository<Game>, IGameRepository
    {
        public GameRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Game> GetByIdWithFullDataAsync(int? id)
        {
            if (id is null) throw new ArgumentNullException();

            Game game = await entities.Include(g => g.GameImages)
                                      .Include(g => g.GamePlatforms)
                                      .ThenInclude(gp => gp.Platform)
                                      .Include(g => g.GameGenres)
                                      .ThenInclude(gg => gg.Genre)
                                      .FirstOrDefaultAsync(g => g.Id == id);

            if (game is null) throw new NullReferenceException();

            return game;
        }
    }
}