using Idle.Emu.Application.Base;
using Idle.Emu.Application.Interfaces;
using Idle.Emu.Messages.Logic.Protos;

namespace Idle.Emu.Application.Events.Auth
{
    public class AuthEvent 
        : EventCommandBase<AuthEvent>, IEventService<IdleReqAuth, IdleRspAuth>
    {
        public IdleRspAuth Response(IdleReqAuth req)
        {
            // add as logged into worldaggregate
            return new IdleRspAuth()
            {
                Status = 0,
                CreateTs = "0",
                Web = 0
            };
        }
    }
}