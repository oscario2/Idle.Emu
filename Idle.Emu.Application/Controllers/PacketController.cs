using System.Collections.Generic;
using Cocos.Zip.Interfaces;
using Cocos.Zip.Services;
using Google.Protobuf;
using Idle.Emu.Application.Handlers;
using Idle.Emu.Application.Interfaces;
using Idle.Emu.Messages;
using Idle.Emu.Messages.Utils;
using Idle.Emu.Packet.Enums;
using Idle.Emu.Packet.Handlers;
using Idle.Emu.Packet.Records;

namespace Idle.Emu.Application.Controllers
{
    public sealed class PacketController
    {
        private readonly TcpPacketReader _reader;
        private readonly IZipService _zip;

        private readonly IPacketHandler<EPacketEvent> _authHandler;
        private readonly IPacketHandler<EPacketEvent> _gameHandler;

        public PacketController()
        {
            _reader = new TcpPacketReader();
            _zip = new GzipStreamService();

            // can be dependency injected
            _authHandler = new AuthRequestHandler();
            _gameHandler = new EventRequestHandler();
        }

        public (byte[], IMessage) ReadIncoming(IEnumerable<byte> data)
        {
            const EPacketDirection dir = EPacketDirection.Incoming;

            // read request
            var packet = ParsePacket(data, dir);
            var id = (EPacketEvent) MessageUtils.ToId(packet.Type, packet.Cmd, (int) dir);

            // create response body
            var proto = _authHandler.Parse(id, packet.Payload);
            proto ??= _gameHandler.Parse(id, packet.Payload);
            if (proto == null) return (null, null);

            // create response packet
            var res = TcpPacketWriter.Create(packet.Type, packet.Cmd, proto.ToByteArray());

            return (res, proto);
        }

        public TcpPacket ParsePacket(IEnumerable<byte> data, EPacketDirection direction)
        {
            // try parse frame
            var packet = _reader.TryCreate(data, direction);
            if (packet == null) return null;

            // payload is empty in e.g pings
            if (packet.Payload.Length < 2) return packet;
            var payload = packet.Payload;

            // decompress if needed
            var magic = new[] {payload[0], payload[1]};
            if (_zip.IsCompressed(magic))
                packet.Payload = _zip.Decompress(payload);

            return packet;
        }
    }
}