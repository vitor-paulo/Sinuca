using Sinuca.Domain.Entities;

namespace Sinuca.Application.Models
{
    public class PlayerRequest
    {
        public string Name { get; set; }
        public bool Active { get; set; }

        public Player ToDocument() => new()
        {
            Name = Name,
            Active = Active
        };
    }
}
