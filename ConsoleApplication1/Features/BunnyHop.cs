using MemoryManager;
using System.Threading;
using ExternalBase.C0re.Structs_Variables;
using static ExternalBase.C0re.Stuff.Hotkeys;

namespace ExternalBase.C0re.Features
{
    class BunnyHop
    {
        static MainClass MainClass;

        public static void BunnyJump()
        {
            MainClass = new MainClass();

            while (true)
            {
                if (BunnyKey)
                {
                    int Flag = MainClass.Memory.rdInt(LocalPlayer.Base + 0x100);
                    if (Flag == 257 || Flag == 263)
                    {
                        MainClass.Memory.WrtInt(MainClass.ClientPointer + Offsets.m_dwForceJump, 5);
                    }
                    else
                    {
                        MainClass.Memory.WrtInt(MainClass.ClientPointer + Offsets.m_dwForceJump, 4);
                    }
                }
                Thread.Sleep(2);
            }
        }
    }
}
