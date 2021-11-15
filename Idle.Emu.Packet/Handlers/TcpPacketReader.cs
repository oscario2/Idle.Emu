using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using Idle.Emu.Packet.Enums;
using Idle.Emu.Packet.Extensions;
using Idle.Emu.Packet.Records;

namespace Idle.Emu.Packet.Handlers
{
    public class TcpPacketReader
    {
        private byte[] _buffer;
        public TcpPacketReader()
        {
            _buffer = Array.Empty<byte>();
        }
        
        /// <summary>
        /// try build frame from buffer
        /// </summary>
        /// <param name="data"></param>
        /// <param name="direction"></param>
        /// <returns></returns>
        public TcpPacket TryCreate(IEnumerable<byte> data, EPacketDirection direction)
        {
            // TODO: handle misaligned frame

            // append packets and re-read until size matches
            _buffer = _buffer.Concat(data).ToArray();

            // consume data
            while (true)
            {
                var buffer = _buffer.ToArray();
                using var ms = new MemoryStream(buffer);
                using var br = new BinaryReader(ms);

                // from dhTcpAgent.lua
                var size = br.ReadUInt16Be();
                var type = (int)br.ReadByte();
                var cmd = (int)br.ReadByte();
                
                // anything beyond 63 is compressed
                type = type > 63 ? type - 63: type;
                
                // TODO: playerId? serverId?
                if (direction == EPacketDirection.Incoming)
                    br.ReadUInt16();

                var payload = br.ReadBytes(size - 2);

                // frame satisfied, enqueue packet, reset frame and return
                if (br.BaseStream.Position == br.BaseStream.Length)
                {
                    _buffer = Array.Empty<byte>();
                    return new TcpPacket(size, type, cmd, payload, direction);
                }

                // set frame to remaining bytes of buffer
                var nextPacket = br.ReadBytes((int) br.BaseStream.Length);
                _buffer = nextPacket;
            }
        }
    }
}