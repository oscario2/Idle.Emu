using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Cocos.Tcp
{
    // use ClientNetServer, seeing it's streaming we'll just build our packet buffer
    public class NativeServer
    {
        private readonly TcpListener _server;
        private readonly ConcurrentDictionary<string, TcpClient> _clients;
        
        private const int TcpBufferSize = 65535;

        private NativeServer(string ip, int port)
        {
            _server = new TcpListener(IPAddress.Parse(ip), port);
            _clients = new ConcurrentDictionary<string, TcpClient>();
        }

        private void Run(Action<byte[]> onData)
        {
            _server.Start();
            while (true)
            {
                Console.WriteLine("Waiting for a connection...");
                var client = _server.AcceptTcpClient();
                Console.WriteLine("Connected!");
                Task.Run(() => HandleIncoming(client, onData));
            }
        }

        private static void HandleIncoming(TcpClient client, Action<byte[]> onData)
        {
            var stream = client.GetStream();
            while (client.Connected)
            {
                // read and dispatch any incoming data
                var buffer = new byte[TcpBufferSize];
                var read = stream.Read(buffer, 0, TcpBufferSize);
                if (read == 0) continue;

                onData(buffer);
            }
        }


        public static void Create(Action<byte[]> onData)
        {
            var server = new NativeServer("127.0.0.1", 5000);
            Task.Run(() => server.Run(onData));
        }
    }
}