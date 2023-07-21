using Sinuca.Application.Models;

namespace Sinuca.Application.Services
{
    public interface IMatchService
    {
        Task InitializeMatch(MatchInitializeRequest request);
        Task CloseMatch(MatchCloseRequest request);
    }
}
