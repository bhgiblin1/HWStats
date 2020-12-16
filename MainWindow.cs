using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System;
using System.Runtime.InteropServices;

namespace HWStats
{
    public partial class MainWindow : Form
    {
        bool alive = true;
        // should be put into the dll, but need to figure out a way to read this.. 8700k overclocks btwn 4.5-5.1. 
        uint cpuMaxClockWithTurbo = 5000;
        public MainWindow()
        {
            InitializeComponent();
            FullScreenBuild();
            new Thread(gpuUpdate).Start();
            new Thread(memoryUpdate).Start();
            new Thread(cpuUpdate).Start();
        }

        private void UserExit(object sender, FormClosingEventArgs e)
        {
            alive = false;
        }

        private void FullScreenBuild()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
        }

        private void BorderPanels_Paint(object sender, PaintEventArgs e)
        {
            // ControlPaint.DrawBorder(e.Graphics, this.cpuPanel.ClientRectangle, Color.DarkGoldenrod, ButtonBorderStyle.Solid);
            // var borderColor = Color.FromArgb(247, 247, 247);
            var borderColor = Color.Gray;
            var borderStyle = ButtonBorderStyle.Dotted;
            var borderWidth = 1;
            var panel = (Panel)sender;

            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle, borderColor, borderWidth, 
                borderStyle, borderColor, borderWidth, borderStyle, borderColor, borderWidth, 
                borderStyle, borderColor, borderWidth, borderStyle);
        }

        private void gpuUpdate()
        {
            var gpuQuery = GPUImporter.CreateGPUQuery();
            var gpuNamePtr = GPUImporter.GetGPUName(gpuQuery);
            var gpuName = Marshal.PtrToStringUni(gpuNamePtr);
            uint maxClockSpeed = GPUImporter.GetGPUMaxClock(gpuQuery);
            gpuNameLabel.Invoke(new MethodInvoker(delegate
            {
                gpuNameLabel.Text += gpuName;
            }));
            unsafe
            {
                var gpuStats = (GPUImporter.GPUStats*) GPUImporter.GetGPUStats(gpuQuery);
                gpuStats->memoryUsage = 0;

                while (alive)
                {
                    updateStat(gpuTemp, gpuStats->temp);
                    updateStat(gpuLoad, gpuStats->load);
                    updateStat(gpuFan, gpuStats->fanUsage);
                    updateClock(gpuClockSpeed, gpuClockSpeedText, maxClockSpeed, gpuStats->clock);
                    updateMemoryStat(vRamLoad, Convert.ToInt32((gpuStats->memoryUsage / gpuStats->memoryTotal) * 100), Math.Round(gpuStats->memoryUsage, 2));

                    Thread.Sleep(1000);
                }
            }
            GPUImporter.DestroyGPUQuery(gpuQuery);
        }

        private void memoryUpdate()
        {
            var memoryQuery = MemoryImporter.CreateMemoryQuery();
            unsafe
            {
                var memoryStats = (MemoryImporter.MemoryStats*) MemoryImporter.GetMemoryStats(memoryQuery);
                while (alive)
                {
                    updateMemoryStat(ramLoad, (int) memoryStats->load, Math.Round(memoryStats->amtUsed, 2));
                    Thread.Sleep(1000);
                }
            }
            MemoryImporter.DestroyMemoryQuery(memoryQuery);
        }
        private void cpuUpdate()
        {
            var cpuQuery = CPUImporter.CreateCPUQuery();
            var cpuNamePtr = CPUImporter.GetCPUName(cpuQuery);
            var cpuName = Marshal.PtrToStringUni(cpuNamePtr);
            cpuNameLabel.Invoke(new MethodInvoker(delegate
            {
                cpuNameLabel.Text += cpuName;
            }));
            short nominalClock = CPUImporter.GetCPUNominalClock(cpuQuery);
            unsafe 
            {
                var cpuStats = (CPUImporter.CPUStats*)CPUImporter.GetCPUStats(cpuQuery);
                while (alive)
                {
                    updateStat(cpuTemp, cpuStats->temp);
                    updateStat(cpuLoad, (int) Math.Round(cpuStats->load));
                    var clockSpeed = nominalClock * (cpuStats->clockPercent / 100.0);
                    updateClock(cpuClockSpeed, cpuClockSpeedText, cpuMaxClockWithTurbo, (uint)clockSpeed);
                    Thread.Sleep(1000);
                }
            }
            CPUImporter.DestroyCPUQuery(cpuQuery);
        }

        private void updateClock(CircularProgressBar.CircularProgressBar clockSpeed, Label clockSpeedText, uint maxClockSpeed, uint clock)
        {
            // the clockspeed progress indicator's 0% is really value = 15%. 100% is really value = 86%
            // just a circular progress bar with a pane covering it
            int minVal = 15;
            int maxVal = 86;
            if (clock >= 0 && clock <= maxClockSpeed)
            {
                double clockPercent = (clock / (double) maxClockSpeed);
                double scaledPercent = ((maxVal - minVal) * clockPercent) + minVal;
                try
                {
                    clockSpeedText.Invoke(new MethodInvoker(delegate
                    {
                        clockSpeed.Value = (int)scaledPercent;
                        clockSpeedText.Text = clock.ToString();
                    }));
                }
                catch (Exception) { }
            }
        }
        private void updateStat(CircularProgressBar.CircularProgressBar toUpdate, uint val)
        {
            updateStat(toUpdate, (int)val);
            return;
        }

        private void updateStat(CircularProgressBar.CircularProgressBar toUpdate, int val)
        {
            if (val >= 0 && val <= 100)
            {
                try
                {
                    toUpdate.Invoke(new MethodInvoker(delegate
                    {
                        toUpdate.Value = val;
                        toUpdate.Text = val.ToString();
                    }));
                }
                catch (Exception) { }
            }
        }
        private void updateMemoryStat(CircularProgressBar.CircularProgressBar toUpdate, int load, double val)
        {
            if (load >= 0 && load <= 100)
            {
                try
                {
                    toUpdate.Invoke(new MethodInvoker(delegate
                    {
                        toUpdate.Value = load;
                        toUpdate.Text = val.ToString();
                    }));
                }
                catch (Exception) { }
            }
        }
    }
}
