using System;
using System.Runtime.InteropServices;

namespace HWStats
{
    class CPUImporter
    {
        [DllImport("HWStatsLib.dll", CallingConvention = CallingConvention.Cdecl)]
        static public extern IntPtr CreateCPUQuery();

        [DllImport("HWStatsLib.dll", CallingConvention = CallingConvention.Cdecl)]
        static public extern void DestroyCPUQuery(IntPtr cpuQuery);

        [DllImport("HWStatsLib.dll", CallingConvention = CallingConvention.Cdecl)]
        static public extern IntPtr GetCPUStats(IntPtr cpuQuery);

        [DllImport("HWStatsLib.dll", CallingConvention = CallingConvention.Cdecl)]
        static public extern IntPtr GetCPUName(IntPtr CpuQuery);

        [DllImport("HWStatsLib.dll", CallingConvention = CallingConvention.Cdecl)]
        static public extern short GetCPUNominalClock(IntPtr CpuQuery);

        [StructLayout(LayoutKind.Sequential)]
        unsafe public struct CPUStats
        {
            public int temp;
            public double load;
            public double clockPercent;
        }
    }
}
