using System.Linq;

namespace Cocos.Protobuf
{
    public static class CocosUtils
    {
        /// <summary>
        /// PB_PLAYER_ITEM to PlayerItem
        /// </summary>
        /// <returns></returns>
        public static string ParsePbName(string name)
        {
            var pb = name.ToLower().Replace("pb", "");

            var capitalize = pb
                .Split("_").Where(k => !string.IsNullOrEmpty(k))
                .Select(k => char.ToUpper(k[0]) + k[1..]);

            return string.Join("", capitalize);
        }
    }
}