using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWStats
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
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
    }
}
