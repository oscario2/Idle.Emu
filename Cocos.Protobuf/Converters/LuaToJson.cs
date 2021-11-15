using System;
using System.Collections.Generic;
using System.Linq;

namespace Cocos.Protobuf.Converters
{
    public class ProtoField
    {
        public string Message { get; init; }
        public string Name { get; set; }
        public int Number { get; set; }
        public string Label { get; set; }
        public string Type { get; set; }
        public bool CustomType { get; set; }
    }

    public class ProtoState
    {
        /// <summary>
        /// k = parent, v = has fields
        /// </summary>
        public Dictionary<string, bool> Messages { get; init; }
        public HashSet<string> Imports { get; init; }
        public Dictionary<string, ProtoField> Fields { get; init; }
    }

    internal static class LuaToJson
    {
        /// <summary>
        /// parse _pb.lua file generated from lua-protoc-gen
        /// </summary>
        /// <param name="lines"></param>
        /// <param name="opts"></param>
        /// <returns></returns>
        public static ProtoState Parse(IEnumerable<string> lines, CocosProtoOpts opts)
        {
            var state = new ProtoState()
            {
                Messages = new Dictionary<string, bool>(),
                Imports = new HashSet<string>(),
                Fields = new Dictionary<string, ProtoField>(),
            };

            foreach (var line in lines)
            {
                // local PB_PLAYER = protobuf.Descriptor()
                if (line.EndsWith(".Descriptor()"))
                {
                    // assume no fields ".FieldDescriptor()"
                    var field = GetDescriptor(line);
                    state.Messages.Add(opts.Prefix + CocosUtils.ParsePbName(field), false);
                }

                // local PB_PLAYER_NAME_FIELD = protobuf.FieldDescriptor()
                else if (line.EndsWith(".FieldDescriptor()"))
                {
                    var field = GetDescriptor(line);
                    
                    var parent = state.Messages.Keys.ToList()[^1];
                    state.Messages[parent] = true;
                        
                    state.Fields.Add(field, new ProtoField() {Message = parent });
                }

                // PB_PLAYER_NAME_FIELD.name = "name"
                else if (line.Contains("_FIELD.name"))
                {
                    var (k, v) = GetField(line);
                    state.Fields[k].Name = v;
                }

                // PB_PLAYER_NAME_FIELD.number = 1
                else if (line.Contains("_FIELD.number"))
                {
                    var (k, v) = GetField(line);
                    state.Fields[k].Number = Convert.ToInt32(v);
                }

                // PB_PLAYER_NAME_FIELD.label = 2
                else if (line.Contains("_FIELD.label"))
                {
                    var (k, v) = GetField(line);
                    state.Fields[k].Label = ProtoMap.Label[Convert.ToInt32(v)];
                }

                // PB_PLAYER_SKILL_FIELD.message_type = DR2_COMM_PB.PB_SKILL
                else if (line.Contains("_FIELD.message_type"))
                {
                    var (k, v) = GetField(line);
                    var path = v.Split(".");

                    // if message is imported from another _pb file
                    if (path.Length == 2)
                    {
                        var import = path.First().ToLower();
                        if (!state.Imports.Contains(import)) state.Imports.Add(import);
                    }

                    state.Fields[k].Type = CocosUtils.ParsePbName(path.Last()); // overwrite
                    state.Fields[k].CustomType = true;
                }

                // PB_PLAYER_NAME_FIELD.type = 9
                else if (line.Contains("_FIELD.type"))
                {
                    var (k, v) = GetField(line);

                    if (!state.Fields[k].CustomType)
                        state.Fields[k].Type = ProtoMap.Type[Convert.ToInt32(v)];
                }
            }

            return state;
        }

        /// <summary>
        /// (PB_PLAYER_NAME_FIELD) = protobuf.FieldDescriptor()
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        private static string GetDescriptor(string line)
        {
            return line.Split(" = ").First().Replace("local ", "");
        }

        /// <summary>
        /// (PB_PLAYER_NAME_FIELD).type = (9)
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        private static (string, string) GetField(string line)
        {
            var a = line.Split(".").First();
            var b = line.Split(" = ").Last().Replace("\"", "");

            return (a, b);
        }
    }
}