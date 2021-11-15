using Idle.Emu.Application.Base;
using Idle.Emu.Application.Interfaces;
using Idle.Emu.Messages.Login.Protos;

namespace Idle.Emu.Application.Events.Auth
{
    /// <summary>
    /// list of available servers on start
    /// </summary>
    public class ServersLoginEvent : EventCommandBase<ServersLoginEvent>,
        IEventService<IdleReqServersLogin, IdleRspServersLogin>
    {
        public IdleRspServersLogin Response(IdleReqServersLogin req)
        {
            return new IdleRspServersLogin()
            {
                Servers =
                {
                    new IdleServerLogin()
                    {
                        Sid = 100,
                        Sname = "Emulator",
                        Pname = "Hello",
                        Plogo = 29,
                        Plv = 6,
                        Flag = 2,
                        Uid = 12345
                    }
                }
            };
        }
    }
}