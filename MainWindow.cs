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
        public MainWindow()
        {
            InitializeComponent();
            //FullScreenBuild();
            new Thread(gpuUpdate).Start();
            new Thread(memoryUpdate).Start();

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
            gpuNameLabel.Text += gpuName;
            unsafe
            {
                var gpuStats = (GPUImporter.GPUStats*) GPUImporter.GetGPUStats(gpuQuery);
                while (alive)
                {
                    updateStat(gpuTemp, gpuStats->temp);
                    updateStat(gpuLoad, gpuStats->load);
                    updateStat(gpuFan, gpuStats->fanUsage);
                    updateClock(gpuClockSpeed, gpuClockSpeedText, maxClockSpeed, gpuStats->clock);

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
                    updateStat(ramLoad, memoryStats->load);
                    try
                    {
                        memorySpeedText.Invoke(new MethodInvoker(delegate
                        {
                            memorySpeedText.Text = Math.Round(memoryStats->amtUsed, 2).ToString() + " GB";
                        }));
                    }
                    catch (Exception) { }
                }
            }
            MemoryImporter.DestroyMemoryQuery(memoryQuery);
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
            if (val >= 0 && val <= 100)
            {
                try
                {
                    toUpdate.Invoke(new MethodInvoker(delegate
                    {
                        toUpdate.Value = (int)val;
                        toUpdate.Text = val.ToString();
                    }));
                }
                catch (Exception) { }
            }
        }
    }
}
