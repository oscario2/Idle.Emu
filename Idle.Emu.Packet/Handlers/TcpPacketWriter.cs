using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Idle.Emu.Packet.Extensions;

namespace Idle.Emu.Packet.Handlers
{
    public static class TcpPacketWriter
    {
        public static byte[] Create(int type, int cmd, ReadOnlySpan<byte> data)
        {
            using var ms = new MemoryStream();
            using var bw = new BinaryWriter(ms);
            
            bw.WriteInt16Be((short)(data.Length + 2));
            bw.Write((byte)type);
            bw.Write((byte)cmd);
            
            // playerId/serverId? just from "send"
            // bw.WriteInt16Be(0x0);
            bw.Write(data);

            return ms.ToArray();
        }
    }
}