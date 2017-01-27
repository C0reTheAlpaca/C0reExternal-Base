using System;
using System.Threading;
using ExternalBase.C0re.Structs_Variables;
using static ExternalBase.C0re.Stuff.Hotkeys;
using static ExternalBase.C0re.Stuff.DLLImports;

namespace ExternalBase.C0re.Features
{
    class Triggerbot
    {
        public static void Trigger()
        {
            while (true)
            {
                for (int i = 0; i < 64; i++)
                {
                    int EntityInCrossID = MainClass.Memory.rdInt(LocalPlayer.Base + Offsets.m_iCrossHairID);

                    if (EntityInCrossID > 0 && EntityInCrossID <= 64)
                    {
                        int EntityBase = MainClass.Memory.rdInt(MainClass.ClientPointer + Offsets.m_dwEntityList + (EntityInCrossID - 1) * 0x10);
                        int EntityTeam = MainClass.Memory.rdInt(EntityBase + Offsets.m_iTeamNum);
                        if ((TriggerKey /*|| TriggerAutofire*/) && EntityTeam != LocalPlayer.Team)
                        {
                            mouse_event(MouseEventLeftDown, 0, 0, 0, new UIntPtr());
                            mouse_event(MouseEventLeftUp, 0, 0, 0, new UIntPtr());
                            Thread.Sleep(25);
                        }
                    }
                }
                Thread.Sleep(1);
            }
        }
    }
}
