using System;
using Google.Protobuf;

namespace Idle.Emu.Application.Interfaces
{
    internal interface IPacketHandler<in T>
        where T : Enum
    {
        /// <summary>
        /// generate response to unary request
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        IMessage Parse(T id, ReadOnlySpan<byte> data);
    }
}