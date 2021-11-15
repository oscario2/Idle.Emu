using Idle.Emu.Application.Base;
using Idle.Emu.Application.Interfaces;
using Idle.Emu.Messages.Logic.Protos;

namespace Idle.Emu.Application.Events.Hero
{
    public class WearEvent
        : EventCommandBase<WearEvent>, IEventService<IdleReqWear, IdleRspWear>
    {
        public IdleRspWear Response(IdleReqWear req)
        {
            return new IdleRspWear() {Status = 0};
        }
    }
}