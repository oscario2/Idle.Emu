using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cocos.Shared.Extensions
{
    public static class ByteArrayExtension
    {
        public static bool IsEqual(this ReadOnlySpan<byte> a, ReadOnlySpan<byte> b)
        {
            return a.SequenceEqual(b);
        }
    }
}