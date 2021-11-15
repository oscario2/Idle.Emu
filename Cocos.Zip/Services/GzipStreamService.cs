using System;
using System.IO;
using Cocos.Shared.Extensions;
using Cocos.Zip.Interfaces;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace Cocos.Zip.Services
{
    public class GzipStreamService : IZipService
    {
        public byte[] Compress(byte[] data)
        {
            // leave empty to be expandable
            using var inputStream = new MemoryStream();
            using var outputStream = new DeflaterOutputStream(inputStream);

            outputStream.Write(data, 0, data.Length);
            outputStream.Finish();

            return inputStream.ToArray();
        }

        public byte[] Decompress(byte[] data)
        {
            var outputStream = new MemoryStream();

            using var compressedStream = new MemoryStream(data);
            using var inputStream = new InflaterInputStream(compressedStream);

            inputStream.CopyTo(outputStream);
            outputStream.Position = 0;

            return outputStream.ToArray();
        }

        /// <summary>
        /// check if payload is compressed
        /// </summary>
        /// <param name="data">2 bytes to validate against zlib magic</param>
        /// <returns></returns>
        public bool IsCompressed(ReadOnlySpan<byte> data)
        {
            if (data.Length != 2) throw new Exception("Only send in two bytes");
            
            var min = new byte[] {0x78, 0x01};
            var med = new byte[] {0x78, 0x9C};
            var max = new byte[] {0x78, 0xDA};

            return data.IsEqual(min) || data.IsEqual(med) || data.IsEqual(max);
        }
    }
}