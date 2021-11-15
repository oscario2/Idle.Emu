using Idle.Emu.Shared.Interfaces.Domain;
using Idle.Emu.Shared.Interfaces.Infrastructure;

namespace Idle.Emu.Shared.Interfaces.Application
{
    public interface IMapper
    {
        IPersistence ToPersistence(IEntity entity);
        IEntity ToEntity(IPersistence persistence);
    }
}