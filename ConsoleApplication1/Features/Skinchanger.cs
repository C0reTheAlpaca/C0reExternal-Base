using System.Threading;
using ExternalBase.C0re.Structs_Variables;
using static ExternalBase.C0re.Structs_Variables.Weapons;

namespace ExternalBase.C0re.Features
{
    class SkinChanger
    {
        public void IterateThroughWeapons()
        {
            while (true)
            {
                int OverrideTexture = 0;
                int WeaponBase, WeaponEntity, WeaponID, XuID, CurrentTexture, WeaponOwner;

                for (var i = 0 + 1; i <= 16; ++i)
                {
                    WeaponBase = MainClass.Memory.rdInt(LocalPlayer.Base + Offsets.m_hMyWeapons + (i - 1) * 0x4);
                    WeaponBase = WeaponBase & 0xFFF;
                    WeaponEntity = MainClass.Memory.rdInt(MainClass.ClientPointer + Offsets.m_dwEntityList + (WeaponBase - 1) * 0x10);
                    WeaponID = MainClass.Memory.rdInt(WeaponEntity + Offsets.m_iItemDefinitionIndex);
                    XuID = MainClass.Memory.rdInt(WeaponEntity + Offsets.m_OriginalOwnerXuidLow);
                    CurrentTexture = MainClass.Memory.rdInt(WeaponEntity + Offsets.m_nFallbackPaintKit);

                    if (WeaponID != 0)
                    {
                        switch (WeaponID)
                        {
                            case (int)WeaponIDs.WEAPON_AK47:
                                OverrideTexture = 474;
                                break;
                            case (int)WeaponIDs.WEAPON_M4A1_SILENCER:
                                OverrideTexture = 430;
                                break;
                            case (int)WeaponIDs.WEAPON_M4A1:
                                OverrideTexture = 309;
                                break;
                            case (int)WeaponIDs.WEAPON_AWP:
                                OverrideTexture = 344;
                                break;
                            case (int)WeaponIDs.WEAPON_KNIFE_BUTTERFLY:
                                OverrideTexture = 59;
                                break;
                            default: // DO NOT CHANGE
                                OverrideTexture = -999;
                                break;
                        }
                        if (OverrideTexture != -999)
                        {
                            if (CurrentTexture != OverrideTexture)
                            {
                                MainClass.Memory.WrtInt(WeaponEntity + Offsets.m_nFallbackPaintKit, OverrideTexture);
                                MainClass.Memory.WrtInt(WeaponEntity + Offsets.m_nFallbackSeed, 1337);
                                MainClass.Memory.WrtInt(WeaponEntity + Offsets.m_nFallbackStatTrak, 1337);
                                MainClass.Memory.WrtFloat(WeaponEntity + Offsets.m_flFallbackWear, 0.00001f);
                                MainClass.Memory.WrtInt(WeaponEntity + Offsets.m_iAccountID, XuID);

                                ForceFullUpdate();
                            }
                        }
                    }
                }
                Thread.Sleep(5);
            }
        }

        private void ForceFullUpdate()
        {
            MainClass.Memory.WrtInt(LocalPlayer.ClientState + 0x16C, -1);
        }
    }
}
