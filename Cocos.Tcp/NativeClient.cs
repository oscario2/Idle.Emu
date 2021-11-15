using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Cocos.Tcp
{
    public class NativeClient
    {
        private readonly TcpClient _client;
        private readonly Queue<byte[]> _queue;
        private const int TcpBufferSize = 65535;
        
        private bool IsConnected => _client is {Connected: true};

        private NativeClient(string ip, int port)
        {
            _client = new TcpClient(ip, port);
            _queue = new Queue<byte[]>();
        }

        private void Run(Action<byte[]> onData)
        {
            var stream = _client.GetStream();
            while (_client.Connected)
            {
                // send enqueued packets
                while (_queue.TryDequeue(out var packet))
                {
                    stream.Write(packet, 0, packet.Length);
                    stream.Flush();
                }

                // read and dispatch any incoming data
                var buffer = new byte[TcpBufferSize];
                var read = stream.Read(buffer, 0, TcpBufferSize);
                if (read == 0) continue;

                onData(buffer);
            }
        }

        public void Send(byte[] data)
        {
            if (!IsConnected) return;
            
            _queue.Enqueue(data);
        }

        public void Disconnect()
        {
            if (!IsConnected) return;
            
            _client.GetStream().Close();
            _client.Close();
        }


        public static NativeClient Create(Action<byte[]> onData)
        {
            var client = new NativeClient("127.0.0.1", 5000);
            Task.Run(() => client.Run(onData));
            // set any Timer for e.g heartbeats here

            return client;
        }
    }
}