﻿using System;
using System.Threading;
using Shared.Util;

namespace AuthServer
{
    internal static class Program
    {
        private static readonly Mutex Mutex = new Mutex(true, "{d13f8db8-307c-4588-abc1-7b8dae93acc0}");
        
        private static void Main(string[] args)
        {
#if !DEBUG
            try
            {
#endif
                if (Mutex.WaitOne(TimeSpan.Zero, true))
                {
                    AuthServer.Instance.Run();
                    Mutex.ReleaseMutex();
                }
                else
                {
                    Console.WriteLine("Server already running!");
                    Console.ReadKey();
                }
#if !DEBUG
            }
            catch (Exception ex)
            {
                Log.Exception(ex, "An exception occured while running the server.");
                
                Console.WriteLine("Press any key to exit");
                ConsoleUtil.Exit(1);
            }
#endif
        }
    }
}