using Idle.Emu.Packet.Enums;

namespace Idle.Emu.Packet.Records
{
    public record TcpPacket
    {
        public int Size { get; }
        public int Type { get; }
        public int Cmd { get; }
        public byte[] Payload { get; set; }
        public EPacketDirection Direction { get; }

        public TcpPacket(int size, int type, int cmd, byte[] payload, EPacketDirection direction)
        {
            Size = size;
            Type = type;
            Cmd = cmd;
            Payload = payload;
            Direction = direction;
        } 
    }
}