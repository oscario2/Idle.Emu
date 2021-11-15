using Idle.Emu.Application.Base;
using Idle.Emu.Application.Interfaces;
using Idle.Emu.Messages.Logic.Protos;

namespace Idle.Emu.Application.Events.Game
{
    public class CdKeyEvent
        : EventCommandBase<CdKeyEvent>, IEventService<IdleReqCdkey, IdleRspCdkey>
    {
        public IdleRspCdkey Response(IdleReqCdkey req)
        {
            return new IdleRspCdkey() {Status = 0};
        }
    }
}