using Google.Protobuf;
using Idle.Emu.Shared;

namespace Idle.Emu.Application.Extensions
{
    public static class ProtoExtensions
    {
        private static readonly JsonFormatter JFormat =
            new JsonFormatter(JsonFormatter.Settings.Default.WithFormatEnumsAsIntegers(true));

        /// <summary>
        /// convert proto to json
        /// </summary>
        /// <param name="proto"></param>
        /// <returns>empty string if proto is null</returns>
        public static string ToJson(this IMessage proto)
        {
            return Guard.IsNull(proto) ? "" : JFormat.Format(proto);
        }
    }
}