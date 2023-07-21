using Sinuca.Application.Interfaces;
using Sinuca.Application.Models;

namespace Sinuca.Application.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;

        public PlayerService(IPlayerRepository playerRepository)
        {
            _playerRepository = playerRepository;
        }

        public async Task Create(PlayerRequest request)
        {
            await _playerRepository.CreateAsync(request.ToDocument());
        }
    }
}
