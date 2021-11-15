using System;
using System.Collections.Generic;
using System.Text;
using Idle.Emu.Generator.Interfaces;
using Idle.Emu.Generator.Records;
using Idle.Emu.Generator.Templates;
using Idle.Emu.Messages;
using Idle.Emu.Messages.Utils;

namespace Idle.Emu.Generator.Generators
{
    internal class NetGenerator : IOutputGenerator
    {
        public string Extension => "cs";

        public string GetProtoNamespace(string nms)
        {
            return $"option csharp_namespace = \"{nms}\";\n";
        }

        public IEnumerable<string> ToEnum(IEnumerable<EventMap> events)
        {
            var evtEnum = new List<string>()
            {
                $"namespace {MessageUtils.GetNameSpace()} \n{{",
                "\tpublic enum EPacketEvent \n\t{",
            };

            foreach (var evt in events)
            {
                var req = MessageUtils.ToId(evt.Type, evt.Cmd, 0);
                var res = MessageUtils.ToId(evt.Type, evt.Cmd, 1);
                
                evtEnum.Add($"\t\t{evt.Name}Request = {req},");
                evtEnum.Add($"\t\t{evt.Name}Response = {res},\n");
            }
            
            evtEnum.Add("\t}");
            evtEnum.Add("}");

            return evtEnum;
        }

        public string ToCode(List<EventMap> events)
        {
            var nms = MessageUtils.GetNameSpace();
            
            var imports = new HashSet<string>();
            var lines = new List<string>();

            foreach (var evt in events)
            {
                var mod = $"{nms}.{Utils.ConvertPbFileName(evt.Module)}";
                if (!imports.Contains(mod)) imports.Add($"using {mod}.Protos");
                
                lines.Add($"case EPacketEvent.{evt.Name}Request: return typeof({evt.Request});");
                lines.Add($"case EPacketEvent.{evt.Name}Response: return typeof({evt.Response});");
                lines.Add("\n");
            }

            return SwitchTemplate.Get(events, imports, lines);
        }
    }
}