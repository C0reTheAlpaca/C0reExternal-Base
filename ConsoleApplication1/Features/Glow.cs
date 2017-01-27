using System;
using MemoryManager;
using System.Drawing;
using System.Threading;
using System.Collections.Generic;
using ExternalBase.C0re.Structs_Variables;
using static ExternalBase.C0re.Structs_Variables.Entity;

namespace ExternalBase.C0re.Features
{
    class Glow
    {
        public static void GlowESP()
        {
            Color Color;

            while (true)
            {
                for (var i = 0; i < 64; i++)
                {
                    if (Arrays.Entity[i].Base == 0)
                        continue;
                    if (Arrays.Entity[i].Base == LocalPlayer.Base)
                        continue;
                    if (Arrays.Entity[i].Health < 1)
                        continue;
                    if (Arrays.Entity[i].Dormant == 1)
                        continue;

                    if (Arrays.Entity[i].Team != LocalPlayer.Team)
                        Color = Color.FromArgb(255, 244, 92, 66);
                    else
                        Color = Color.FromArgb(255, 122, 244, 66);

                    MainClass.Memory.WrtFloat(LocalPlayer.GlowBase + Arrays.Entity[i].GlowIndex * 0x38 + 0x4, (float)Color.R / 255);
                    MainClass.Memory.WrtFloat(LocalPlayer.GlowBase + Arrays.Entity[i].GlowIndex * 0x38 + 0x8, (float)Color.G / 255);
                    MainClass.Memory.WrtFloat(LocalPlayer.GlowBase + Arrays.Entity[i].GlowIndex * 0x38 + 0xC, (float)Color.B / 255);
                    MainClass.Memory.WrtFloat(LocalPlayer.GlowBase + Arrays.Entity[i].GlowIndex * 0x38 + 0x10, 1.0f);
                    MainClass.Memory.WrtByte(LocalPlayer.GlowBase + Arrays.Entity[i].GlowIndex * 0x38 + 0x24, 1);
                }
                Thread.Sleep(5);
            }
        }
    }
}
