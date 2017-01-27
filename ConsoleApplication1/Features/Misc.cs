using System.Threading;
using ExternalBase.C0re.Structs_Variables;
using static ExternalBase.C0re.Stuff.Hotkeys;

namespace ExternalBase.C0re.Features
{
    class Misc
    {
        public static void Miscellaneous()
        {
            while (true)
            {
                //NOFLASH
                MainClass.Memory.WrtFloat(LocalPlayer.Base + Offsets.m_flFlashMaxAlpha, 0f);
                Thread.Sleep(5);

                //BHOP
                if (JumpKey)
                {
                    if (LocalPlayer.JumpFlags == 257 || LocalPlayer.JumpFlags == 263)
                    {
                        MainClass.Memory.WrtInt(MainClass.ClientPointer + Offsets.m_dwForceJump, 5);
                    }
                    else
                    {
                        MainClass.Memory.WrtInt(MainClass.ClientPointer + Offsets.m_dwForceJump, 4);
                    }
                }
            }
        }
    }
}
