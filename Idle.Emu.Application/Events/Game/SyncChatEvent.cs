using Idle.Emu.Application.Base;
using Idle.Emu.Application.Interfaces;
using Idle.Emu.Messages.Comm.Protos;
using Idle.Emu.Messages.Logic.Protos;

namespace Idle.Emu.Application.Events.Game
{
    public class SyncChatEvent :
        EventCommandBase<SyncChatEvent>, IEventService<IdleReqSyncChat, IdleRspSyncChat>
    {
        public IdleRspSyncChat Response(IdleReqSyncChat req)
        {
            return new IdleRspSyncChat()
            {
                Msgs =
                {
                    new IdleChat()
                    {
                        Uid = 95924604627,
                        Logo = 5308,
                        Lv = 23,
                        Vip = 0,
                        Name = "oscario2",
                        Type = 1,
                        Text = "chat test",
                        Time = 1634469957
                    }
                }
            };
        }
    }
}