using System.Collections.Generic;
// ReSharper disable StringLiteralTypo

namespace Cocos.Protobuf.Converters
{
    internal static class ProtoMap
    {
        internal static readonly Dictionary<int, string> Type = new Dictionary<int, string>
        {
            {1, "double"},
            {2, "float"},
            {3, "int64"},
            {4, "uint64"},
            {5, "int32"},
            {6, "fixed64"},
            {7, "fixed32"},
            {8, "bool"},
            {9, "string"},
            {10, "group"},
            {11, "message"},
            {12, "bytes"},
            {13, "uint32"},
            {14, "enum"},
            {15, "sfixed32"},
            {16, "sfixed64"},
            {17, "sint32"},
            {18, "sint64"}
        };
        
        internal static readonly Dictionary<int, string> Label = new Dictionary<int, string>
        {
            {1, "optional"},
            {2, "required"},
            {3, "repeated"}
        };
    }
}