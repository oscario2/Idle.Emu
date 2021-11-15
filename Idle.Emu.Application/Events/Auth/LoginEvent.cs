using Idle.Emu.Application.Base;
using Idle.Emu.Application.Interfaces;
using Idle.Emu.Messages.Login.Protos;

namespace Idle.Emu.Application.Events.Auth
{
    public class LoginEvent 
        : EventCommandBase<LoginEvent>, IEventService<IdleReqLogin, IdleRspLogin>
    {
        public IdleRspLogin Response(IdleReqLogin req)
        {
            // add uid to world aggregate as logged in
            return new IdleRspLogin()
            {
                Status = 0,
                Session = "8df19b7dd413b632222d591859f5783a",
                Sid = 100,
                IsFormal = false,
                Uid = 12345,
                CreateTs = "1634468755"
            };
        }
    }
}