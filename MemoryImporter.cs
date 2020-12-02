using System;
using System.Runtime.InteropServices;

namespace HWStats
{
    class MemoryImporter
    {
        [DllImport("HWStatsLib.dll", CallingConvention = CallingConvention.Cdecl)]
        static public extern IntPtr CreateMemoryQuery();
        [DllImport("HWStatsLib.dll", CallingConvention = CallingConvention.Cdecl)]
        static public extern void DestroyMemoryQuery(IntPtr memQuery);
        [DllImport("HWStatsLib.dll", CallingConvention = CallingConvention.Cdecl)]
        static public extern IntPtr GetMemoryStats(IntPtr memQuery);


        [StructLayout(LayoutKind.Sequential)]
        unsafe public struct MemoryStats
        {
            public uint load;
            public double amtUsed;
        }
    }
}
