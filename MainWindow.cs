using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System;

namespace HWStats
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            // FullScreenBuild();
            Thread gpuThread = new Thread(gpuUpdate);
            gpuThread.IsBackground = true;
            gpuThread.Start();
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
            //string gpuName = GPUImporter.GetGPUName(gpuQuery);
            uint maxClockSpeed = GPUImporter.GetGPUMaxClock(gpuQuery);
            // gpuNameLabel.Text += gpuName;
            unsafe
            {
                GPUImporter.GPUStats* gpuStats = (GPUImporter.GPUStats*)GPUImporter.GetGPUStats(gpuQuery);
                while (true)
                {
                    updateStat(gpuTemp, gpuStats->temp);
                    updateStat(gpuLoad, gpuStats->load);
                    updateStat(gpuFan, gpuStats->fanUsage);
                    updateClock(gpuClockSpeed, gpuClockSpeedText, maxClockSpeed, gpuStats->clock);

                    Thread.Sleep(1000);
                }
            }
            // TODO: !!
            GPUImporter.DestroyGPUQuery(gpuQuery);
        }

        private void updateClock(CircularProgressBar.CircularProgressBar clockSpeed, Label clockSpeedText, uint maxClockSpeed, uint clock)
        {
            // the clockspeed progress indicator's 0% is really value = 15%. 100% is really value = 86%
            // just a circular progress bar with a pane covering it
            int minVal = 15;
            int maxVal = 86;
            if (clock >= 0 && clock <= maxClockSpeed)
            {
                int clockPercent = (int) ((clock / (double) maxClockSpeed) * 100);
                int scaledPercent = (int) (((clockPercent - minVal) / (double) (maxVal - minVal)) * 100);
                clockSpeedText.Invoke(new MethodInvoker(delegate
                {
                    clockSpeedText.Text = clock.ToString();
                }));
            }
        }

        private void updateStat(CircularProgressBar.CircularProgressBar toUpdate, uint val)
        {
            if (val >= 0 && val <= 100)
            {
                toUpdate.Invoke(new MethodInvoker(delegate
                {
                    toUpdate.Value = (int)val;
                    toUpdate.Text = val.ToString();
                }));
            }
        }
    }
}
