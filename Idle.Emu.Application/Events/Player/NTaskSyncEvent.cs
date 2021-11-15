using System.Collections.Generic;
using Idle.Emu.Application.Base;
using Idle.Emu.Application.Interfaces;
using Idle.Emu.Messages.Comm.Protos;
using Idle.Emu.Messages.Logic.Protos;

namespace Idle.Emu.Application.Events.Player
{
    public class NTaskSyncEvent
        : EventCommandBase<NTaskSyncEvent>, IEventService<IdleReqNtaskSync, IdleRspNtaskSync>
    {
        public IdleRspNtaskSync Response(IdleReqNtaskSync req)
        {
            return new IdleRspNtaskSync()
            {
                Status = 0,
                Tasks =
                {
                    new IdleNtask()
                    {
                        Id = 1003,
                        Count = 0,
                        Status = 1
                    }
                },
                Data =
                {
                    new IdleNtSync()
                    {
                        Type = 15,
                        Value = {new List<long>() {0}}
                    }
                }
            };
        }
    }
}