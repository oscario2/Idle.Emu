using Google.Protobuf;

namespace Idle.Emu.Application.Interfaces
{
    internal interface IEventService<in T, out TR>
        where T : IMessage
        where TR : IMessage
    {
        /// <summary>
        /// check domain or repositories and build response
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        TR Response(T req);
    }
}