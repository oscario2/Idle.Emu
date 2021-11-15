using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Idle.Emu.Shared
{
    public static class Log
    {
        public static bool IsDebug { get; set; } = true;

        private static string _outFile;

        // private static readonly string OutName = DateTime.Now.ToString("MM-dd-yy HH.mm");
        private static readonly string OutName = DateTime.Now.ToString("MM-dd-yy HH.mm");

        private static void Init()
        {
            Directory.CreateDirectory("Logs");
            _outFile = $"Logs/{OutName}.txt";
        }

        public static void Error<T>(T message, bool trace = false, bool writeToFile = true,
            [CallerMemberName] string caller = null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            caller = trace ? $"[{caller}] " : "";
            PrintLine($"{caller}{message}", "Error", writeToFile);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void Warning<T>(T message, bool trace = false, bool writeToFile = false,
            [CallerMemberName] string caller = null)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            caller = trace ? $"[{caller}] " : "";
            PrintLine($"{caller}{message}", "Warning", writeToFile);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void Debug<T>(T message, bool trace = false, bool writeToFile = false,
            [CallerMemberName] string caller = null)
        {
            if (!IsDebug) return;

            Console.ForegroundColor = ConsoleColor.Cyan;
            caller = trace ? $"[{caller}] " : "";
            PrintLine($"{caller}{message}", "Debug", writeToFile);
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void Info<T>(T message, bool trace = false, bool writeToFile = false,
            [CallerMemberName] string caller = null)
        {
            caller = trace ? $"[{caller}] " : "";
            PrintLine($"{caller}{message}", "Info", writeToFile);
        }

        private static void PrintLine<T>(T message, string type, bool writeToFile = false)
        {
            if (writeToFile)
            {
                if (_outFile == null) Init();

                using var sw = new StreamWriter(_outFile!, true);
                sw.WriteLine($"{GetTimeStamp()}[{type}] {message}");
            }

            Console.WriteLine(GetTimeStamp() + " " + message);
        }

        private static string GetTimeStamp()
        {
            return $"[{DateTime.Now:MM-dd-yy HH:mm:ss}]:";
        }
    }
}