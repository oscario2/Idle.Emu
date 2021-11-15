using System;

namespace Idle.Emu.Messages.Utils
{
    public static class MessageUtils
    {
        /// <summary>
        /// generated message id format + direction
        /// </summary>
        /// <param name="type"></param>
        /// <param name="cmd"></param>
        /// <param name="direction"></param>
        /// <returns></returns>
        public static int ToId(int type, int cmd, int direction)
        {
            return Convert.ToInt32($"{type}0{cmd}{direction}");
        }

        /// <summary>
        /// root namespace for generated protos and messages
        /// </summary>
        /// <returns></returns>
        public static string GetNameSpace()
        {
            return typeof(MessageUtils).Namespace?.Replace(".Utils", "");
        }
    }
}