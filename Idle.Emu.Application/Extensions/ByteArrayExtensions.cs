using System;
using Google.Protobuf;

namespace Idle.Emu.Application.Extensions
{
    public static class ByteArrayExtensions
    {
        public static T ToProto<T>(this ReadOnlySpan<byte> data)
            where T : IMessage, new()
        {
            var _ = typeof(T).Name;

            var message = new T();
            message.MergeFrom(data);

            return message;
        }
    }
}