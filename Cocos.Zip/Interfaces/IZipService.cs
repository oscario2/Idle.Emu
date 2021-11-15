using System;

namespace Cocos.Zip.Interfaces
{
    public interface IZipService
    {
        byte[] Compress(byte[] data);
        
        byte[] Decompress(byte[] data);

        bool IsCompressed(ReadOnlySpan<byte> data);
    }
}