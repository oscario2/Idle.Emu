using System;
using Google.Protobuf;
using Idle.Emu.Application.Events.Game;
using Idle.Emu.Application.Events.Hook;
using Idle.Emu.Application.Events.Market;
using Idle.Emu.Application.Events.Player;
using Idle.Emu.Application.Extensions;
using Idle.Emu.Application.Interfaces;
using Idle.Emu.Messages;
using Idle.Emu.Messages.Logic.Protos;
using Idle.Emu.Messages.Login.Protos;

// ReSharper disable IdentifierTypo

namespace Idle.Emu.Application.Handlers
{
    internal sealed class EventRequestHandler : IPacketHandler<EPacketEvent>
    {
        public IMessage Parse(EPacketEvent id, ReadOnlySpan<byte> data)
        {
            // all definitions (interfaces) are placed in "shared" and all implementations ar placed in "application"
            // "application" accesses repository and domain, each of those two cannot access each other
            
            // every numeric value are dispatched as int * 100 to avoid floating precision errors
            // alphabetical order
            switch (id)
            {
                case EPacketEvent.IdleAloginRequest:
                    var aLoginReq = data.ToProto<IdleReqAlogin>();
                    return ALoginEvent.Instance.Response(aLoginReq);

                case EPacketEvent.IdleCdkeyRequest:
                    var cdKey = data.ToProto<IdleReqCdkey>();
                    return CdKeyEvent.Instance.Response(cdKey);

                case EPacketEvent.IdleEchoRequest:
                    var echoReq = data.ToProto<IdleReqEcho>();
                    return EchoEvent.Instance.Response(echoReq);

                case EPacketEvent.IdleGachaRequest:
                    var gachaReq = data.ToProto<IdleReqGacha>();
                    return GachaEvent.Instance.Response(gachaReq);

                case EPacketEvent.IdleHmarketSyncRequest:
                    var hMarketSyncReq = data.ToProto<IdleReqHmarketSync>();
                    return HMarketSyncEvent.Instance.Response(hMarketSyncReq);

                case EPacketEvent.IdleHookAskRequest:
                    var hookAskReq = data.ToProto<IdleReqHookAsk>();
                    return HookAskEvent.Instance.Response(hookAskReq);
                
                case EPacketEvent.IdleHookRewardRequest:
                    var hookRewardReq = data.ToProto<IdleReqHookReward>();
                    return HookRewardEvent.Instance.Response(hookRewardReq);

                case EPacketEvent.IdleOpMailRequest:
                    var opMailReq = data.ToProto<IdleReqOpMail>();
                    return OpMailEvent.Instance.Response(opMailReq);
                
                case EPacketEvent.IdleMonthmarketSyncRequest:
                    var monthMarketSyncReq = data.ToProto<IdleReqMonthmarketSync>();
                    return MonthMarketSyncEvent.Instance.Response(monthMarketSyncReq);
                
                case EPacketEvent.IdleSyncChatRequest:
                    var syncChatReq = data.ToProto<IdleReqSyncChat>();
                    return SyncChatEvent.Instance.Response(syncChatReq);
                
                default:
                    return null;
            }
        }
    }
}