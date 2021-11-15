using System.Collections.Generic;
using Cocos.Protobuf.Converters;

namespace Cocos.Protobuf
{
    public static class CocoProto
    {
        public static IEnumerable<string> ToProtoCode(IEnumerable<string> lines, CocosProtoOpts opts)
        {
            var state = LuaToJson.Parse(lines, opts);
            return JsonToProto.Parse(state, opts);
        }
        
        public static IEnumerable<string> ToProtoCode(ProtoState state, CocosProtoOpts opts)
        {
            return JsonToProto.Parse(state, opts);
        }
        
        public static ProtoState ToProtoState(IEnumerable<string> lines, CocosProtoOpts opts)
        { 
            return LuaToJson.Parse(lines, opts);
        }
    }
}