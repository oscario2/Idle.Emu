using Idle.Emu.Application.Base;
using Idle.Emu.Application.Interfaces;
using Idle.Emu.Messages.Comm.Protos;
using Idle.Emu.Messages.Logic.Protos;

namespace Idle.Emu.Application.Events.Player
{
    /// <summary>
    /// check-in reward (activity login)
    /// </summary>
    public class ALoginEvent
        : EventCommandBase<ALoginEvent>, IEventService<IdleReqAlogin, IdleRspAlogin>
    {
        public IdleRspAlogin Response(IdleReqAlogin req)
        {
            return new IdleRspAlogin()
            {
                Status = 0,
                Bag = new IdleBag()
                {
                    Items =
                    {
                        new IdleItem()
                        {
                            Id = 2,
                            Num = 150
                        }
                    }
                }
            };
        }
    }
}