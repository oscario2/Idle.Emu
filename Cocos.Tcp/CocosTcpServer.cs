using System;
using System.Linq;
using System.Net.Sockets;
using NetCoreServer;
using Buffer = System.Buffer;

namespace Cocos.Tcp
{
    internal class CocosTcpSession : TcpSession
    {
        private readonly CocosTcpOpts<TcpSession> _opts;

        public CocosTcpSession(TcpServer server, CocosTcpOpts<TcpSession> opts) : base(server)
        {
            _opts = opts;
        }

        private void Dispatch(byte[] data)
        {
            SendAsync(data);
        }

        protected override void OnReceived(byte[] buffer, long offset, long size)
        {
            var slice = new byte[size];
            Buffer.BlockCopy(buffer, (int)offset, slice, 0, (int)size);
            
            _opts.OnData?.Invoke(Id, slice);
        }

        protected override void OnError(SocketError error)
        {
            _opts.OnError?.Invoke(error);
        }
    }

    public class CocosTcpServer : TcpServer
    {
        private readonly CocosTcpOpts<TcpSession> _opts;

        public CocosTcpServer(CocosTcpOpts<TcpSession> opts) : base(opts.Ip, opts.Port)
        {
            _opts = opts;
        }

        protected override TcpSession CreateSession()
        {
            return new CocosTcpSession(this, _opts);
        }

        protected override void OnError(SocketError error)
        {
            throw new Exception(error.ToString());
        }
        
        protected override void OnConnected(TcpSession session)
        {
            _opts.OnOpen?.Invoke(session);
        }

        protected override void OnDisconnected(TcpSession session)
        {
            _opts.OnDisconnect?.Invoke(session.Id);
        }
    }
}