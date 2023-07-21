using Sinuca.Application.Interfaces;
using Sinuca.Application.Models;

namespace Sinuca.Application.Services
{
    public class MatchService : IMatchService
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IMatchRepository _matchRepository;

        public MatchService(IPlayerRepository playerRepository, IMatchRepository matchRepository)
        {
            _playerRepository = playerRepository;
            _matchRepository = matchRepository;
        }

        public async Task InitializeMatch(MatchInitializeRequest request)
        {
            var findPlayer1 = await _playerRepository.FindAsync(request.Player1);

            var findPlayer2 = await _playerRepository.FindAsync(request.Player2);

            var macth = request.Initalize(findPlayer1, findPlayer2);

            await _matchRepository.CreateAsync(macth);
        }

        public async Task CloseMatch(MatchCloseRequest request)
        {
            await _matchRepository.CloseMatch(request.Close());
        }

        public async Task AddPointPlayer1(MatchPointPlayer1Request request)
        {
            await _matchRepository.AddPointPlayer1(request.AddPoint());
        }

        //public async Task AddPointPlayer2(MatchCloseRequest request)
        //{
        //    await _matchRepository.CloseMatch(request.Close());
        //}

    }
}
