using Idle.Emu.Shared.Interfaces.Application;
using Idle.Emu.Shared.Interfaces.Domain;
using Idle.Emu.Shared.Interfaces.Infrastructure;

namespace Idle.Emu.Application.Mappers
{
    internal class HeroMapper : IMapper
    {
        public IPersistence ToPersistence(IEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public IEntity ToEntity(IPersistence persistence)
        {
            throw new System.NotImplementedException();
        }
    }
}