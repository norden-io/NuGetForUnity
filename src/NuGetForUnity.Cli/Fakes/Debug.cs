﻿#nullable enable

using System;

namespace UnityEngine
{
    internal static class Debug
    {
        internal static bool HasError { get; private set; }

        internal static void LogErrorFormat(string format, params object[] args)
        {
            HasError = true;
            Console.Error.WriteLine(format, args);
        }

        internal static void LogFormat(string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }

        internal static void Log(string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }

        internal static void LogWarning(string format, params object[] args)
        {
            var oldForgroundColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(format, args);
            Console.ForegroundColor = oldForgroundColor;
        }

        internal static void LogWarningFormat(string format, params object[] args)
        {
            Console.WriteLine(format, args);
        }

        internal static void LogError(string format, params object[] args)
        {
            HasError = true;
            Console.Error.WriteLine(format, args);
        }

        internal static void Assert(bool condition)
        {
            System.Diagnostics.Debug.Assert(condition);
        }
    }
}
