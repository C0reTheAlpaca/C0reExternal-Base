using System;
using MemoryManager;
using System.Threading;
using System.Windows.Forms;
using ExternalBase.C0re.Stuff;
using ExternalBase.C0re.Features;
using ExternalBase.C0re.Structs_Variables;
using static ExternalBase.C0re.Structs_Variables.Entity;

namespace ExternalBase.C0re
{
    class MainClass
    {
        public static ProcM Memory = new ProcM("csgo");
        public static int ClientPointer;
        public static int EnginePointer;

        static void Main(string[] args)
        {
            Console.Title = "ExternalBase.C0re";

            if (!Memory.StartProcess())
                Environment.Exit(0);

            ClientPointer = Memory.DllImageAddress("client.dll");
            EnginePointer = Memory.DllImageAddress("engine.dll");

            DLLImports.SetHook();

            for (var i = 0; i < 64; i++)
            {
                Arrays.Entity[i] = new Entity();
            }

            Console.WriteLine(@"  _______  _______  _______  _______ " );
            Console.WriteLine(@" (  ____ \(  __   )(  ____ )(  ____ \" );
            Console.WriteLine(@" | (    \/| (  )  || (    )|| (    \/" );
            Console.WriteLine(@" | |      | | /   || (____)|| (__    " );
            Console.WriteLine(@" | |      | (/ /) ||     __)|  __)   " );
            Console.WriteLine(@" | |      |   / | || (\ (   | (      " );
            Console.WriteLine(@" | (____/\|  (__) || ) \ \__| (____/\" );
            Console.WriteLine(@" (_______/(_______)|/   \__/(_______/" );
            Console.WriteLine(@"");
            Console.ForegroundColor = ConsoleColor.Green;

            AdressReader AdressReader = new AdressReader();
            Thread DataReaderThread = new Thread(AdressReader.ReadData);
            DataReaderThread.Start();
            Console.WriteLine("Thread: 'AdressReader' started.");

            Glow Glow = new Glow();
            Thread GlowThread = new Thread(Glow.GlowESP);
            GlowThread.Start();
            Console.WriteLine("Thread: 'Glow-ESP' started.");

            Triggerbot Triggerbot = new Triggerbot();
            Thread TriggerbotThread = new Thread(Triggerbot.Trigger);
            TriggerbotThread.Start();
            Console.WriteLine("Thread: 'Triggerbot' started.");

            Misc Misc = new Misc();
            Thread MiscThread = new Thread(Misc.Miscellaneous);
            MiscThread.Start();
            Console.WriteLine("Thread: 'Misc' started.");

            SkinChanger SkinChanger = new SkinChanger();
            Thread SkinChangerThread = new Thread(SkinChanger.IterateThroughWeapons);
            SkinChangerThread.Start();
            Console.WriteLine("Thread: 'SkinChanger' started.");

            Application.Run();
        }
    }
}
