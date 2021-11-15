using Idle.Emu.Application.Base;
using Idle.Emu.Application.Interfaces;
using Idle.Emu.Messages.Comm.Protos;
using Idle.Emu.Messages.Logic.Protos;

namespace Idle.Emu.Application.Events.Market
{
    public class HMarketSyncEvent
        : EventCommandBase<HMarketSyncEvent>, IEventService<IdleReqHmarketSync, IdleRspHmarketSync>
    {
        public IdleRspHmarketSync Response(IdleReqHmarketSync req)
        {
            return new IdleRspHmarketSync()
            {
                Status = 0,
                Item =
                {
                    new IdleHmarket()
                    {
                        Id = 169,
                        Num = 0
                    }
                }
            };
        }
    }
}