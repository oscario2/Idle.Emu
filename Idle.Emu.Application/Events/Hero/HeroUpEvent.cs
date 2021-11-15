using Idle.Emu.Application.Base;
using Idle.Emu.Application.Interfaces;
using Idle.Emu.Messages.Logic.Protos;

namespace Idle.Emu.Application.Events.Hero
{
    public class HeroUpEvent
        : EventCommandBase<HeroUpEvent>, IEventService<IdleReqHeroUp, IdleRspHeroUp>
    {
        public IdleRspHeroUp Response(IdleReqHeroUp req)
        {
            return new IdleRspHeroUp()
            {
                Status = 0
            };
        }
    }
}