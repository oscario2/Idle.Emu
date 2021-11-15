using System;
using System.Collections.Generic;
using System.Reflection;
using Google.Protobuf;
using Idle.Emu.Application.Controllers;
using Idle.Emu.Application.Extensions;
using Idle.Emu.Messages;
using Idle.Emu.Messages.Utils;
using Idle.Emu.Packet.Enums;
using Idle.Emu.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Idle.Emu.Application.Utils
{
    internal class DebugUtils
    {
        private static readonly PacketController Controller = new PacketController();

        private static MethodInfo GetGenericMethod<T>(string method)
            where T : new()
        {
            return typeof(T).GetMethod(method, BindingFlags.NonPublic | BindingFlags.Static);
        }

        private static IMessage ParseProto<T>(byte[] data)
            where T : IMessage, new()
        {
            var message = new T();
            message.MergeFrom(data);

            return message;
        }

        /// <summary>
        /// parse and write packet as a json object to file
        /// </summary>
        internal static void DebugPacket(IEnumerable<byte> data, EPacketDirection direction)
        {
            var packet = Controller.ParsePacket(data, direction);
            var id = MessageUtils.ToId(packet.Type, packet.Cmd, (int) direction);

            // get type from factory
            var type = PacketPush.Type((EPacketPush)id);
            type ??= PacketEvent.Type((EPacketEvent)id);
            if (type == null) throw new Exception("Unhandled");

            // parse using reflection
            var method = GetGenericMethod<DebugUtils>("ParseProto");
            var proto = (IMessage) method?
                .MakeGenericMethod(type)
                .Invoke(null, new object[] {packet.Payload});

            // cast to event or push id
            Enum eid = Enum.IsDefined(typeof(EPacketEvent), id)
                ? (EPacketEvent) id
                : (EPacketPush) id;

            // print
            var obj = new JObject
            {
                ["name"] = eid.ToString(),
                ["type"] = packet.Type,
                ["cmd"] = packet.Cmd,
                ["body"] = (JToken) JsonConvert.DeserializeObject(proto.ToJson())
            };

            Log.Debug(obj, writeToFile: true);
        }
    }
}