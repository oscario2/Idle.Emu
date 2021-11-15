using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Cocos.Protobuf;
using Cocos.Protobuf.Converters;
using Cocos.Zip.Services;
using Idle.Emu.Apk;
using Idle.Emu.Generator.Converters;
using Idle.Emu.Generator.Generators;
using Idle.Emu.Generator.Interfaces;
using Idle.Emu.Generator.Records;
using Idle.Emu.Generator.Templates;
using Idle.Emu.Messages;
using Idle.Emu.Messages.Utils;
using Idle.Emu.Shared;

namespace Idle.Emu.Generator
{
    public static class Program
    {
        private const string ToCopy = "ToCopy";

        /// <summary>
        /// generate .proto files for each .lua in resources
        /// </summary>
        internal static void Main()
        {
            var opts = new CocosProtoOpts()
            {
                Prefix = "Idle",
                Package = "public",
                Namespaces = new List<string>()
            };

            // language generator
            var net = new NetGenerator();

            //
            var protos = WriteProtos(opts, net);

            //
            var eventMap = BuildEventMap(protos, opts, net);
            
            //
            WriteCode(eventMap, net);

            //
            WriteEnum(eventMap, net);

            Console.WriteLine("Done...");
        }

        private static Dictionary<string, ProtoState> WriteProtos(CocosProtoOpts opts, IOutputGenerator gen)
        {
            var folder = $"{ToCopy}/Protos";
            Directory.CreateDirectory(folder);

            var protos = new Dictionary<string, ProtoState>();
            foreach (var file in Directory.GetFiles(Global.Resources, "*_pb.lua", SearchOption.AllDirectories))
            {
                var content = File.ReadAllBytes(file);
                Console.WriteLine($"[.proto]: Processing {file}...");
                opts.Namespaces.Clear();

                // "logic" to "IdleEmu.Grpc.Logic" to prevent ambiguous messages between files
                var nms = $"{MessageUtils.GetNameSpace()}.{Utils.ConvertPbFileName(file)}.Protos";
                opts.Namespaces.Add(gen.GetProtoNamespace(nms));

                // read and convert to .proto
                var lines = Encoding.UTF8.GetString(content).Split(Environment.NewLine);
                var state = CocoProto.ToProtoState(lines, opts);
                var code = CocoProto.ToProtoCode(state, opts);

                // write to .proto file
                var name = Path.GetFileNameWithoutExtension(file);
                File.WriteAllLines($"{folder}/{name}.proto", code);

                // save state for message mapping
                protos.Add(name, state);
            }

            return protos;
        }

        private static List<EventMap> BuildEventMap(IReadOnlyDictionary<string, ProtoState> protos,
            CocosProtoOpts opts,
            IOutputGenerator gen)
        {
            var lines = File.ReadAllLines(Global.Resources + "/app/net/eventName.lua");
            var eventMap = EventConverter.Build(lines, opts);
            var filteredMap = new List<EventMap>();
            
            foreach (var evt in eventMap)
            {
                // NOTE: some events are referenced in "eventName.lua" that doesn't exist in _pb.lua
                if (!protos[evt.Module].Messages.ContainsKey(evt.Request))
                    continue;
                
                filteredMap.Add(evt);
            }

            return filteredMap;    
        }

        private static void WriteCode(List<EventMap> eventMap, IOutputGenerator generate)
        {
            // var folder = $"{ToCopy}/Types";
            // Directory.CreateDirectory(folder);
            
            const string name = "PacketEvent";
            Console.WriteLine($"[.cs]: Processing {name}");

            var code = generate.ToCode(eventMap);
            File.WriteAllText($"{ToCopy}/{name}.cs", code);
        }

        private static void WriteEnum(IEnumerable<EventMap> eventMap, IOutputGenerator generate)
        {
            // var folder = $"{ToCopy}/Enums";
            // Directory.CreateDirectory(folder);
            
            const string name = "EPacketEvent";
            Console.WriteLine($"[enum]: Processing {name}");

            var enums = generate.ToEnum(eventMap);
            File.WriteAllLines($"{ToCopy}/{name}.cs", enums);
        }
    }
}