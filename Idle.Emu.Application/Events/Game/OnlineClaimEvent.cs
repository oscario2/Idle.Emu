using Idle.Emu.Application.Base;
using Idle.Emu.Application.Interfaces;
using Idle.Emu.Messages.Comm.Protos;
using Idle.Emu.Messages.Logic.Protos;

namespace Idle.Emu.Application.Events.Game
{
    public class OnlineClaimEvent :
        EventCommandBase<OnlineClaimEvent>, IEventService<IdleReqOnlineClaim, IdleRspOnlineClaim>
    {
        public IdleRspOnlineClaim Response(IdleReqOnlineClaim req)
        {
            return new IdleRspOnlineClaim()
            {
                Status = 0,
                Online = new IdleOnline()
                {
                    Id = 3,
                    Cd = 480
                }
            };
        }
    }
}