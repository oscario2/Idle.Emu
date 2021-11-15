using System;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Cocos.Tcp;
using Cocos.Zip.Services;
using Google.Protobuf;
using Idle.Emu.Application.Controllers;
using Idle.Emu.Application.Utils;
using Idle.Emu.Messages;
using Idle.Emu.Messages.Login.Protos;
using Idle.Emu.Packet.Enums;
using Idle.Emu.Packet.Handlers;
using Idle.Emu.Shared;
using NetCoreServer;
using Xunit;

namespace Application.Tests
{
    public class PacketIntegrationTests
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

        [Fact]
        public void ZipPacketStream()
        {
            var packets = ZipService.ReadFiles(Global.Resources + "/packets.zip", "");

            // sort send/recv packets after timestamp
            var sorted = packets.Keys
                .OrderBy(k => long.Parse(Path.GetFileNameWithoutExtension(k).Split('_')[0]))
                .ThenBy(k => int.Parse(Path.GetFileNameWithoutExtension(k).Split('_')[1]));

            foreach (var key in sorted)
            {
                var direction = key.Contains("recv") ? EPacketDirection.Outgoing : EPacketDirection.Incoming;
                DebugUtils.DebugPacket(packets[key], direction);
            }
        }

        [Fact]
        public async Task LocalSingleRequest()
        {
            // arrange
            var clients = new ConcurrentDictionary<Guid, TcpSession>();
            var controller = new PacketController();

            const int vsn = 179;
            var success = false;

            // server
            void ServerOnConnect(TcpSession session)
            {
                clients.TryAdd(session.Id, session);
            }

            void ServerOnRecv(Guid id, byte[] data)
            {
                // recv packet from client
                var (_, proto) = controller.ReadIncoming(data);
                Assert.IsType<IdleRspPub>(proto);
                Assert.Equal(vsn, ((IdleRspPub) proto).Vsn);

                success = true;
            }

            // act
            var serverOpts = GetOpts<TcpSession>(null, ServerOnConnect, ServerOnRecv);
            var server = new CocosTcpServer(serverOpts);
            server.Start();


            // client
            void ClientOnConnect(TcpClient client)
            {
                var data = new IdleReqPub() {Language = 0, Vsn = vsn};
                var packet = TcpPacketWriter.Create(0x1, 0x2, data.ToByteArray());

                Assert.True(client.SendAsync(packet));
            }

            // act
            var clientOpts = GetOpts<TcpClient>("127.0.0.1", ClientOnConnect, null);
            var client = new CocosTcpClient(clientOpts);
            client.ConnectAsync();

            // TODO: timeout to an assert failed
            while (!success) await Task.Delay(100);
        }

        [Fact]
        public async Task RemoteSingleRequest()
        {
            // arrange
            var clients = new ConcurrentDictionary<Guid, TcpSession>();
            var controller = new PacketController();
            var success = false;

            // server
            void ServerOnConnect(TcpSession session)
            {
                clients.TryAdd(session.Id, session);
            }

            void ServerOnRecv(Guid id, byte[] data)
            {
                if (success) return;

                // recv packet from client
                var (res, proto) = controller.ReadIncoming(data);
                Assert.IsType<IdleRspPub>(proto);

                if (!clients.TryGetValue(id, out var client)) return;

                client.SendAsync(res);
                client.Disconnect();

                success = true;
            }

            // act
            var opts = GetOpts<TcpSession>(null, ServerOnConnect, ServerOnRecv);
            var server = new CocosTcpServer(opts);
            server.Start();

            // TODO: timeout to an assert failed
            while (!success) await Task.Delay(100);
        }

        [Fact]
        public async Task RemoteStreamRequest()
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

            // TODO: timeout to an assert failed
            while (true) await Task.Delay(100);
        }
    }
}