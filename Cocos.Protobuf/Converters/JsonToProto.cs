using System;
using System.Collections.Generic;
using System.Linq;

namespace Cocos.Protobuf.Converters
{
    internal static class JsonToProto
    {
        private static Dictionary<string, List<string>> ParseFields(ProtoState state, CocosProtoOpts opts)
        {
            var proto = new Dictionary<string, List<string>>();

            foreach (var field in state.Fields.Values)
            {
                var parent = field.Message;
                var type = field.CustomType
                    ? $"{opts.Prefix ?? ""}{field.Type}"
                    : field.Type;

                // required int32 id = 1;
                var line = $"{field.Label} {type} {field.Name} = {field.Number};";

                if (!proto.ContainsKey(parent!))
                    proto.Add(parent, new List<string>());

                proto[parent].Add(line);
            }

            return proto;
        }

        internal static IEnumerable<string> Parse(ProtoState state, CocosProtoOpts opts)
        {
            // syntax
            var lines = new List<string>
            {
                $"// generated {DateTime.Now:g}",
                "syntax = \"proto2\";\n"
            };

            // namespaces
            lines.AddRange(opts.Namespaces);

            // package
            lines.Add($"package {opts.Package ?? "cocos"};\n");

            // imports
            lines.AddRange(state.Imports.Select(file => $"import \"{file}.proto\";\n"));

            // messages with fields
            var protos = ParseFields(state, opts);
            foreach (var (k, v) in protos)
            {
                lines.Add($"message {k} {{");
                lines.AddRange(v.Select(field => "\t" + field));
                lines.Add("}\n");
            }

            // messages without fields
            foreach (var (k, v) in state.Messages)
            {
                if (v) continue;
                lines.Add($"message {k} {{ }}\n");
            }

            return lines;
        }
    }
}