using System;
using System.Net;
using System.Net.Sockets;

namespace Cocos.Tcp
{
    public record CocosTcpOpts<T>
        where T : IDisposable
    {
        public IPAddress Ip { get; init; }
        public int Port { get; init; }
        public Action<T> OnOpen { get; init; }
        public Action<Guid, byte[]> OnData { get; init; }
        public Action<SocketError> OnError { get; init; }
        public Action<Guid> OnDisconnect { get; init; }
    }
}