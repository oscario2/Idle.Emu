using Idle.Emu.Application.Base;
using Idle.Emu.Application.Interfaces;
using Idle.Emu.Messages.Comm.Protos;
using Idle.Emu.Messages.Logic.Protos;

namespace Idle.Emu.Application.Events.Hook
{
    public class HookRewardEvent
        : EventCommandBase<HookRewardEvent>, IEventService<IdleReqHookReward, IdleRspHookReward>
    {
        public IdleRspHookReward Response(IdleReqHookReward req)
        {
            // req.Type == 1 ? exp : req.Type == 2 ? loot
            return new IdleRspHookReward()
            {
                Status = 0,
                Reward = new IdleBag()
                {
                    Items =
                    {
                        new IdleItem()
                        {
                            Id = 10,
                            Num = 175323
                        }
                    }
                }
            };
        }
    }
}