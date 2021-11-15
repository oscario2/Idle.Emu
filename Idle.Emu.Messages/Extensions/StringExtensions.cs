namespace Idle.Emu.Messages.Extensions
{
    public static class StringExtensions
    {
        public static string ToUpperFirstChar(this string input)
        {
            return input.Length < 1
                ? input
                : char.ToUpper(input[0]) + input[1..];
        }
    }
}