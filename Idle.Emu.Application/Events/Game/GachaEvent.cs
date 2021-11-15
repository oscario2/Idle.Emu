using Idle.Emu.Application.Base;
using Idle.Emu.Application.Interfaces;
using Idle.Emu.Messages.Comm.Protos;
using Idle.Emu.Messages.Logic.Protos;

namespace Idle.Emu.Application.Events.Game
{
    /// <summary>
    /// summon a hero
    /// </summary>
    public class GachaEvent :
        EventCommandBase<GachaEvent>, IEventService<IdleReqGacha, IdleRspGacha>
    {
        public IdleRspGacha Response(IdleReqGacha req)
        {
            return new IdleRspGacha()
            {
                Status = 0,
                Heroes =
                {
                    new IdleHero()
                    {
                        Hid = 8,
                        Id = 1201,
                        Lv = 1,
                        Star = 0,
                        Flag = 0
                    }
                }
            };
        }
    }
}