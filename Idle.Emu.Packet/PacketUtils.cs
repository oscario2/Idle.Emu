using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Idle.Emu.Packet
{
    public class PacketUtils
    {
        /// <summary>
        /// hexdump binary into 16 width table
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string HexDump(ReadOnlySpan<byte> data)
        {
            const int lineWidth = 16;

            byte ReplaceControlCharacterWithDot(byte character)
                => character is < 31 or >= 127 ? (byte) 46 /* dot */ : character;

            byte[] ReplaceControlCharactersWithDots(IEnumerable<byte> characters)
                => characters.Select(ReplaceControlCharacterWithDot).ToArray();

            var result = new StringBuilder();
            for (var pos = 0; pos < data.Length;)
            {
                var line = data.Slice(pos, Math.Min(lineWidth, data.Length - pos)).ToArray();

                var asHex = string.Join(" ", line.Select(v => v.ToString("X2", CultureInfo.InvariantCulture)));
                asHex += new string(' ', lineWidth * 3 - 1 - asHex.Length);

                var asCharacters = Encoding.ASCII.GetString(ReplaceControlCharactersWithDots(line));
                result.Append(FormattableString.Invariant($"{pos:X4} {asHex} {asCharacters}\n"));

                pos += line.Length;
            }

            return result.ToString();
        }
    }
}