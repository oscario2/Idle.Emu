using System.IO;
using System.Linq;
using Idle.Emu.Messages.Extensions;

namespace Idle.Emu.Generator
{
    internal static class Utils
    {
        /// <summary>
        /// "dr2_logic_pb" to "Logic"
        /// </summary>
        /// <returns></returns>
        public static string ConvertPbFileName(string lua)
        {
            return Path.GetFileNameWithoutExtension(lua)
                .Replace("_pb", "")
                .Split("_")
                .Last()
                .ToUpperFirstChar();
        }
    }
}