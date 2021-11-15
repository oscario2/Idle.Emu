using Idle.Emu.Application.Base;
using Idle.Emu.Application.Interfaces;
using Idle.Emu.Messages.Login.Protos;

namespace Idle.Emu.Application.Events.Auth
{
    public class SaltEvent
        : EventCommandBase<SaltEvent>, IEventService<IdleReqSalt, IdleRspSalt>
    {
        public IdleRspSalt Response(IdleReqSalt req)
        {   
            // [auth.lua]: local str = salt .. "rwmkxhgi6;578i650" .. pswd
            // [auth.lua]: local checksum = dh.Crypto:md5(str, #str)
            return new IdleRspSalt()
            {
                Status = 0,
                Salt = "4cf44899ae4086939b7b8042d63b4871",
                Uid = 54572068
            };
        }
    }
}