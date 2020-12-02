using System;
using System.Text;
using System.Runtime.InteropServices;


namespace HWStats
{
    class GPUImporter
    {
        [DllImport("HWStatsLib.dll", CallingConvention = CallingConvention.Cdecl)]
        static public extern IntPtr CreateGPUQuery();

        [DllImport("HWStatsLib.dll", CallingConvention = CallingConvention.Cdecl)]
        static public extern void DestroyGPUQuery(IntPtr gpuQuery);

        [DllImport("HWStatsLib.dll", CallingConvention = CallingConvention.Cdecl)]
        static public extern IntPtr GetGPUStats(IntPtr gpuQuery);
        
        [DllImport("HWStatsLib.dll", CallingConvention = CallingConvention.Cdecl)]
        static public extern IntPtr GetGPUName(IntPtr gpuQuery);
       
        [DllImport("HWStatsLib.dll", CallingConvention = CallingConvention.Cdecl)]
        static public extern uint GetGPUMaxClock(IntPtr gpuQuery);

        [StructLayout(LayoutKind.Sequential)]
        unsafe public struct GPUStats
        {
            public uint temp;
            public uint clock;
            public uint fanUsage;
            public uint load;
        }
    }
}
