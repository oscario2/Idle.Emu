using System;
using System.Collections.Concurrent;
using System.Net;
using System.Threading.Tasks;
using Cocos.Tcp;
using Idle.Emu.Application.Controllers;
using NetCoreServer;

namespace Idle.Emu.Runner
{
    public static class Program
    {
        private static CocosTcpOpts<T> GetOpts<T>(string ip, Action<T> onOpen, Action<Guid, byte[]> onData)
            where T : IDisposable
        {
            return new CocosTcpOpts<T>()
            {
                Ip = ip == null ? IPAddress.Any : IPAddress.Parse(ip),
                Port = 5000,
                OnOpen = onOpen,
                OnData = onData,
                OnError = (error) => throw new Exception(error.ToString())
            };
        }
        
        internal static async Task Main()
        {
            var clients = new ConcurrentDictionary<Guid, TcpSession>();
            var controller = new PacketController();

            // server
            void ServerOnConnect(TcpSession session)
            {
                clients.TryAdd(session.Id, session);
            }

            void ServerOnRecv(Guid id, byte[] data)
            {
                // recv packet from client
                var (res, proto) = controller.ReadIncoming(data);
                if (res == null || proto == null) return;

                if (!clients.TryGetValue(id, out var client)) return;
                client.SendAsync(res);
            }

            // act
            var opts = GetOpts<TcpSession>(null, ServerOnConnect, ServerOnRecv);
            var server = new CocosTcpServer(opts);
            server.Start();
            
            Console.WriteLine("Started...");

            // TODO: timeout to an assert failed
            while (true) await Task.Delay(100);
        }
    }
}