using Idle.Emu.Application.Base;
using Idle.Emu.Application.Interfaces;
using Idle.Emu.Messages.Comm.Protos;
using Idle.Emu.Messages.Logic.Protos;

namespace Idle.Emu.Application.Events.Hook
{
    public class HookAskEvent
        : EventCommandBase<HookAskEvent>, IEventService<IdleReqHookAsk, IdleRspHookAsk>
    {
        public IdleRspHookAsk Response(IdleReqHookAsk req)
        {
            return new IdleRspHookAsk()
            {
                Status = 0,
                Reward = new IdleBag()
                {
                    Items =
                    {
                        new IdleItem()
                        {
                            Id = 40003,
                            Num = 74
                        }
                    },
                    Equips =
                    {
                        new IdleEquip()
                        {
                            Id = 14001,
                            Num = 114
                        }
                    }
                }
            };
        }
    }
}