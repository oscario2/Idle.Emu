using Idle.Emu.Application.Base;
using Idle.Emu.Application.Interfaces;
using Idle.Emu.Messages.Comm.Protos;
using Idle.Emu.Messages.Logic.Protos;

namespace Idle.Emu.Application.Events.Market
{
    public class MonthMarketSyncEvent
        : EventCommandBase<MonthMarketSyncEvent>, IEventService<IdleReqMonthmarketSync, IdleRspMonthmarketSync>
    {
        public IdleRspMonthmarketSync Response(IdleReqMonthmarketSync req)
        {
            return new IdleRspMonthmarketSync()
            {
                Status = 0,
                Mpiece =
                {
                    new IdleHmarket()
                    {
                        Id = 244,
                        Num = 0
                    }
                },
                Mequip =
                {
                    new IdleHmarket()
                    {
                        Id = 96,
                        Num = 0
                    }
                },
                Mskin =
                {
                    new IdleHmarket()
                    {
                        Id = 225,
                        Num = 0
                    }
                },
                Mlimit =
                {
                    new IdleHmarket()
                    {
                        Id = 250,
                        Num = 0,
                        Cd = 651222
                    }
                }
            };
        }
    }
}