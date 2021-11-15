using System.Collections.Generic;
using Idle.Emu.Generator.Records;
using Idle.Emu.Messages;
using Idle.Emu.Messages.Utils;

namespace Idle.Emu.Generator.Templates
{
    public static class SwitchTemplate
    {
        /// <summary>
        /// generate template string
        /// </summary>
        /// <param name="events"></param>
        /// <param name="imports"></param>
        /// <param name="lines"></param>
        /// <returns></returns>
        public static string Get(IEnumerable<EventMap> events, IEnumerable<string> imports, IEnumerable<string> lines)
        {
            var nms = MessageUtils.GetNameSpace();

            return $@"
using System;
{string.Join(";\n", imports)};

namespace {nms} 
{{
    public static class PacketEvent 
    {{
        public static Type Type(EPacketEvent evt) 
        {{
            switch(evt) 
            {{
                {string.Join("\n\t\t\t\t", lines)}
                default: return null;
            }}
        }}
    }}
}}";
        }
    }
}