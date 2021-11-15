using Idle.Emu.Application.Base;
using Idle.Emu.Application.Interfaces;
using Idle.Emu.Messages.Logic.Protos;

namespace Idle.Emu.Application.Events.Auth
{
    /// <summary>
    /// server version if client needs updating
    /// </summary>
    public class UpEvent
        : EventCommandBase<UpEvent>, IEventService<IdleReqUp, IdleRspUp>
    {
        public IdleRspUp Response(IdleReqUp req)
        {
            return new IdleRspUp()
            {
                Status = 0,
                Vsn = "1.27.29",
                Lv = 0
            };
        }
    }
}