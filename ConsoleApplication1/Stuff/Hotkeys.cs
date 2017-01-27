using System;
using System.Runtime.InteropServices;
using static ExternalBase.C0re.Stuff.DLLImports;

namespace ExternalBase.C0re.Stuff
{
    class Hotkeys 
    {
        public static bool JumpKey = false;
        public static bool TriggerKey = false;

        public static IntPtr hookProc(int code, IntPtr wParam, IntPtr lParam)
        {
            int vkCode = Marshal.ReadInt32(lParam);
            if (wParam == (IntPtr)WM_KEYDOWN && vkCode == 0x20)
            {
                JumpKey = true;
            }
            else if (wParam == (IntPtr)WM_KEYUP && vkCode == 0x20)
            {
                JumpKey = false;
            }
            else if (wParam == (IntPtr)WM_SYSKEYDOWN)
            {
                TriggerKey = true;
            }
            else if (wParam == (IntPtr)WM_KEYUP && vkCode == 0xA4)
            {
                TriggerKey = false;
            }
            return CallNextHookEx(hhook, code, (int)wParam, lParam);
        }
    }
}
