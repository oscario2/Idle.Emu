using System;
using System.Collections.Generic;
using System.IO;
using Cocos.Protobuf;
using Idle.Emu.Generator.Records;

// ReSharper disable CommentTypo

namespace Idle.Emu.Generator.Converters
{
    /// <summary>
    /// eventName.lua
    /// </summary>
    internal static class EventConverter
    {
        public static List<EventMap> Build(IEnumerable<string> lines, CocosProtoOpts opts)
        {
            var maps = new List<EventMap>();
            var map = new EventMap();
            
            foreach (var line in lines)
            {
                // cmd = "echo"
                if (line.Contains("cmd ="))
                {
                    // handle previous round
                    if (map.Name != null)
                    {
                        maps.Add(map);
                        map = new EventMap();
                    }

                    var field = ParseField(line);
                    map.Name = opts.Prefix + CocosUtils.ParsePbName(field);
                }
                // cmd_group = 3
                else if (line.Contains("cmd_group ="))
                {
                    var field = ParseField(line);
                    map.Type = Convert.ToInt32(field);
                }
                // cmd_type = 5
                else if (line.Contains("cmd_type ="))
                {
                    var field = ParseField(line);
                    map.Cmd = Convert.ToInt32(field);
                }
                // module_name = "dr2_logic_pb"
                else if (line.Contains("module_name ="))
                {
                    var field = ParseField(line);
                    map.Module = field;
                }
                // req_name = "pbreq_change_password"
                else if (line.Contains("req_name ="))
                {
                    var field = ParseField(line);
                    map.Request = opts.Prefix + CocosUtils.ParsePbName(field);
                }
                // rsp_name = "pbrsp_change_password"
                else if (line.Contains("rsp_name ="))
                {
                    var field = ParseField(line);
                    map.Response = opts.Prefix + CocosUtils.ParsePbName(field);
                }
            }
            
            // handle last round
            maps.Add(map);

            return maps;
        }

        private static string ParseField(string line)
        {
            var split = line.Split(" = ");

            return split[1]
                .Replace("\"", "")
                .Replace(",", "");
        }
    }
}