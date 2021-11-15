using System;
using Cocos.Crypto.Enums;
using Cocos.Zip.Interfaces;
using Cocos.Zip.Services;

namespace Cocos.Crypto.Factories
{
    public static class CompressFactory
    {
        public static IZipService Create(ECompress cmp)
        {
            return cmp switch
            {
                ECompress.Gzip => new GzipStreamService(),
                _ => throw new ArgumentOutOfRangeException(nameof(cmp), cmp, null)
            };
        }
    }
}