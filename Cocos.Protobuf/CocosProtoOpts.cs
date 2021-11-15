using System.Collections.Generic;

namespace Cocos.Protobuf
{
    public record CocosProtoOpts
    {
        /// <summary>
        /// prefix each proto message/field e.g "message PrefixPlayer"
        /// </summary>
        public string Prefix { get; init; }
            
        /// <summary>
        /// package @value;
        /// </summary>
        public string Package { get; init; }
        
        /// <summary>
        /// option csharp_namespace = @value;
        /// </summary>
        public List<string> Namespaces { get; init; }
    }
}