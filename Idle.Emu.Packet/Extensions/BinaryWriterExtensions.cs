using System.IO;
using System.Net;

namespace Idle.Emu.Packet.Extensions
{
    public static class BinaryWriterExtensions
    {
        public static void WriteInt32Be(this BinaryWriter br, int value)
        {
            br.Write(IPAddress.NetworkToHostOrder(value));
        }
        
        public static void WriteInt16Be(this BinaryWriter br, short value)
        {
            br.Write(IPAddress.NetworkToHostOrder(value));
        }
    }
}