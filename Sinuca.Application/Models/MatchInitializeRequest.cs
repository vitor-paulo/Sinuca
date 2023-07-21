using Sinuca.Domain.Entities;

namespace Sinuca.Application.Models
{
    public class MatchInitializeRequest
    {
        public string Player1 { get; set; }
        public string Player2 { get; set; }

        public Match Initalize(Player player1, Player player2) => new()
        {
            Player1 = player1,
            Player2 = player2,
            PlayerPoints1 = 0,
            PlayerPoints2 = 0,
            Active = true
        };
    }
}
