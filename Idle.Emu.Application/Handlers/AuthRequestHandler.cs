using System;
using Google.Protobuf;
using Idle.Emu.Application.Events.Auth;
using Idle.Emu.Application.Events.Game;
using Idle.Emu.Application.Events.Player;
using Idle.Emu.Application.Extensions;
using Idle.Emu.Application.Interfaces;
using Idle.Emu.Messages;
using Idle.Emu.Messages.Logic.Protos;
using Idle.Emu.Messages.Login.Protos;

namespace Idle.Emu.Application.Handlers
{
    internal class AuthRequestHandler : IPacketHandler<EPacketEvent>
    {
        public IMessage Parse(EPacketEvent id, ReadOnlySpan<byte> data)
        {
            // dispatch order
            switch (id)
            {
                // 0
                case EPacketEvent.IdlePubRequest:
                    var pubReq = data.ToProto<IdleReqPub>();
                    return PubEvent.Instance.Response(pubReq);

                // 1
                case EPacketEvent.IdleServersLoginRequest:
                    var serversLoginReq = data.ToProto<IdleReqServersLogin>();
                    return ServersLoginEvent.Instance.Response(serversLoginReq);

                // 2
                case EPacketEvent.IdleSaltRequest:
                    var saltReq = data.ToProto<IdleReqSalt>();
                    return SaltEvent.Instance.Response(saltReq);

                // 3
                case EPacketEvent.IdleLoginRequest:
                    var loginReq = data.ToProto<IdleReqLogin>();
                    return LoginEvent.Instance.Response(loginReq);

                // 4
                case EPacketEvent.IdleAuthRequest:
                    var authReq = data.ToProto<IdleReqAuth>();
                    return AuthEvent.Instance.Response(authReq);

                // 5
                case EPacketEvent.IdleUpRequest:
                    var upReq = data.ToProto<IdleReqUp>();
                    return UpEvent.Instance.Response(upReq);

                // 6
                case EPacketEvent.IdleSyncRequest:
                    var syncReq = data.ToProto<IdleReqSync>();
                    return SyncEvent.Instance.Response(syncReq);

                // 7
                case EPacketEvent.IdleOnlineClaimRequest:
                    var onlineClaimReq = data.ToProto<IdleReqOnlineClaim>();
                    return OnlineClaimEvent.Instance.Response(onlineClaimReq);

                // 8
                case EPacketEvent.IdleNtaskSyncRequest:
                    var nTaskSyncReq = data.ToProto<IdleReqNtaskSync>();
                    return NTaskSyncEvent.Instance.Response(nTaskSyncReq);


                default:
                    return null;
            }
        }
    }
}