using Idle.Emu.Application.Base;
using Idle.Emu.Application.Interfaces;
using Idle.Emu.Messages.Logic.Protos;

namespace Idle.Emu.Application.Events.Player
{
    public class OpMailEvent
        : EventCommandBase<OpMailEvent>, IEventService<IdleReqOpMail, IdleRspOpMail>
    {
        public IdleRspOpMail Response(IdleReqOpMail req)
        {
            return new IdleRspOpMail() {Status = 0};
        }
    }
}