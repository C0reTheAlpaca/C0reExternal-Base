using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalBase.C0re.Structs_Variables
{
    class Offsets
    {
        //Global
        public static int m_dwLocalPlayer = 0x00AA6834;
        public static int m_iTeamNum = 0xF0;
        public static int m_iHealth = 0xFC;
        public static int m_dwEntityList = 0x04AC90F4;
        public static int m_bDormant = 0xE9;
        public static int m_dwForceJump = 0x04F5FC20;
        public static int m_iCrossHairID = 0x0000AA70;
        public static int m_dwClientState = 0x005C75A4;
        public static int m_dwGlowObject = 0x04FE38C4;
        public static int m_iGlowIndex = 0xA320;
        public static int m_flFlashMaxAlpha = 0xA304;
        public static int m_fFlags = 0x00000100;

        //SkinChanger
        public static int m_iItemDefinitionIndex = 0x2F88;
        public static int m_hMyWeapons = 0x2DE8;
        public static int m_OriginalOwnerXuidLow = 0x3168;
        public static int m_iItemIDLow = 0x2FA4;
        public static int m_iItemIDHigh = 0x2FA0;
        public static int m_nFallbackPaintKit = 0x3170;
        public static int m_nFallbackSeed = 0x3174;
        public static int m_nFallbackStatTrak = 0x317C;
        public static int m_iEntityQuality = 0x2F8C;
        public static int m_flFallbackWear = 0x3178;
        public static int m_iAccountID = 0x2FA0;
    }
}