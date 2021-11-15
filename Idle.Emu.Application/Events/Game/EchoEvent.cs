using Idle.Emu.Application.Base;
using Idle.Emu.Application.Interfaces;
using Idle.Emu.Messages.Login.Protos;

namespace Idle.Emu.Application.Events.Game
{
    public class EchoEvent
        : EventCommandBase<EchoEvent>, IEventService<IdleReqEcho, IdleRspEcho>
    {
        public IdleRspEcho Response(IdleReqEcho req)
        {
            return new IdleRspEcho() { };
        }
    }
}