using System;
using MemoryManager;
using System.Threading;
using ExternalBase.C0re.Structs_Variables;
using static ExternalBase.C0re.Structs_Variables.Entity;

namespace ExternalBase.C0re.Features
{
    class AdressReader
    {
        public static void ReadData()
        {
            while (true)
            {
                //LOCAL
                LocalPlayer.Base = MainClass.Memory.rdInt(MainClass.ClientPointer + Offsets.m_dwLocalPlayer);
                LocalPlayer.Team = MainClass.Memory.rdInt(LocalPlayer.Base + Offsets.m_iTeamNum);
                LocalPlayer.ClientState = MainClass.Memory.rdInt(MainClass.EnginePointer + Offsets.m_dwClientState);
                LocalPlayer.GlowBase = MainClass.Memory.rdInt(MainClass.ClientPointer + Offsets.m_dwGlowObject);
                LocalPlayer.JumpFlags = MainClass.Memory.rdInt(LocalPlayer.Base + Offsets.m_fFlags);

                //ENTITY
                for (var i = 0; i < 64; i++)
                {
                    var Entity = Arrays.Entity[i];
                    Entity.Base = MainClass.Memory.rdInt(MainClass.ClientPointer + Offsets.m_dwEntityList + i * 0x10);
                    if (Entity.Base != 0)
                    {
                        Entity.Team = MainClass.Memory.rdInt(Entity.Base + Offsets.m_iTeamNum);
                        Entity.Health = MainClass.Memory.rdInt(Entity.Base + Offsets.m_iHealth);
                        Entity.Dormant = MainClass.Memory.rdInt(Entity.Base + Offsets.m_bDormant);
                        Entity.GlowIndex = MainClass.Memory.rdInt(Entity.Base + Offsets.m_iGlowIndex);
                        Arrays.Entity[i] = Entity;
                    }
                }
                Thread.Sleep(1);
            }
        }
    }
}
