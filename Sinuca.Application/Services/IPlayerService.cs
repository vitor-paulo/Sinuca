using Sinuca.Application.Models;

namespace Sinuca.Application.Services
{
    public interface IPlayerService
    {
        Task Create(PlayerRequest request);
    }
}
