using System.Text.RegularExpressions;

namespace Idle.Emu.Shared
{
    public static class Guard
    {
        private static readonly Regex SanitizeRegex =
            new Regex("[^a-zA-Z0-9]+", RegexOptions.Compiled);

        /// <summary>
        /// remove any non-alpha numeric characters
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Sanitize(string input)
        {
            return input == null ? null : SanitizeRegex.Replace(input, "");
        }

        public static bool IsNull(object input)
        {
            return input == null;
        }
    }
}