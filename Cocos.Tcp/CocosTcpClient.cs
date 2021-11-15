using System;
using System.Linq;
using System.Net.Sockets;
using TcpClient = NetCoreServer.TcpClient;

namespace Cocos.Tcp
{
    public class CocosTcpClient : TcpClient
    {
        private readonly CocosTcpOpts<TcpClient> _opts;

        public CocosTcpClient(CocosTcpOpts<TcpClient> opts) : base(opts.Ip, opts.Port)
        {
            _opts = opts;
        }
        
        protected override void OnConnected()
        {
            _opts.OnOpen?.Invoke(this);
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

        protected override void OnDisconnected()
        {
            _opts.OnDisconnect?.Invoke(Id);
        }
    }
}