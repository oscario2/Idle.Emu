using System;
using System.IO;

namespace Idle.Emu.Packet.Extensions
{
    public static class BinaryReaderExtensions
    {
        public static ushort ReadUInt16Be(this BinaryReader br)
        {
            return BitConverter.ToUInt16(br.ReadBytesRequired(sizeof(ushort)).Reverse(), 0);
        }

        public static short ReadInt16Be(this BinaryReader br)
        {
            return BitConverter.ToInt16(br.ReadBytesRequired(sizeof(short)).Reverse(), 0);
        }

        public static uint ReadUInt32Be(this BinaryReader br)
        {
            return BitConverter.ToUInt32(br.ReadBytesRequired(sizeof(uint)).Reverse(), 0);
        }

        public static int ReadInt32Be(this BinaryReader br)
        {
            return BitConverter.ToInt32(br.ReadBytesRequired(sizeof(int)).Reverse(), 0);
        }

        private static byte[] Reverse(this byte[] b)
        {
            Array.Reverse(b);
            return b;
        }

        private static byte[] ReadBytesRequired(this BinaryReader binRdr, int byteCount)
        {
            var result = binRdr.ReadBytes(byteCount);

            if (result.Length != byteCount)
                throw new EndOfStreamException(
                    $"{byteCount} bytes required from stream, but only {result.Length} returned.");

            return result;
        }
    }
}