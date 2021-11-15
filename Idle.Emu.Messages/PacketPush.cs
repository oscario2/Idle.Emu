using System;
using Idle.Emu.Messages.Comm.Protos;

namespace Idle.Emu.Messages
{
    public static class PacketPush
    {
        public static Type Type(EPacketPush evt)
        {
            switch (evt)
            {
                case EPacketPush.OnChatData: return typeof(IdleChat);
                default: return null;
            }
        }
    }
}