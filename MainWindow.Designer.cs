namespace HWStats
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.cpuNameLabel = new System.Windows.Forms.Label();
            this.gpuNameLabel = new System.Windows.Forms.Label();
            this.gpuTemp = new CircularProgressBar.CircularProgressBar();
            this.gpuClockSpeed = new CircularProgressBar.CircularProgressBar();
            this.gpuLoad = new CircularProgressBar.CircularProgressBar();
            this.gpuTempLabel = new System.Windows.Forms.Label();
            this.gpuLoadLabel = new System.Windows.Forms.Label();
            this.cpuLoad = new CircularProgressBar.CircularProgressBar();
            this.cpuTemp = new CircularProgressBar.CircularProgressBar();
            this.cpuLoadLabel = new System.Windows.Forms.Label();
            this.cpuTempLabel = new System.Windows.Forms.Label();
            this.gpuMhzPanel = new System.Windows.Forms.Panel();
            this.gpuMHZLabel = new System.Windows.Forms.Label();
            this.gpuClockSpeedText = new System.Windows.Forms.Label();
            this.gpuClockSpeedLbl = new System.Windows.Forms.Label();
            this.cpuClockSpeedLbl = new System.Windows.Forms.Label();
            this.cpuMhzPanel = new System.Windows.Forms.Panel();
            this.cpuMHZLabel = new System.Windows.Forms.Label();
            this.cpuClockSpeedText = new System.Windows.Forms.Label();
            this.cpuClockSpeed = new CircularProgressBar.CircularProgressBar();
            this.gpuFanLabel = new System.Windows.Forms.Label();
            this.gpuFan = new CircularProgressBar.CircularProgressBar();
            this.cpuPanel = new System.Windows.Forms.Panel();
            this.gpuPanel = new System.Windows.Forms.Panel();
            this.ramPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ramGB = new System.Windows.Forms.Label();
            this.vRamLoad = new CircularProgressBar.CircularProgressBar();
            this.ramLoad = new CircularProgressBar.CircularProgressBar();
            this.ramVramLabel = new System.Windows.Forms.Label();
            this.gpuMhzPanel.SuspendLayout();
            this.cpuMhzPanel.SuspendLayout();
            this.cpuPanel.SuspendLayout();
            this.gpuPanel.SuspendLayout();
            this.ramPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cpuNameLabel
            // 
            this.cpuNameLabel.AutoSize = true;
            this.cpuNameLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuNameLabel.Location = new System.Drawing.Point(6, 5);
            this.cpuNameLabel.Name = "cpuNameLabel";
            this.cpuNameLabel.Size = new System.Drawing.Size(51, 23);
            this.cpuNameLabel.TabIndex = 1;
            this.cpuNameLabel.Text = "CPU: ";
            // 
            // gpuNameLabel
            // 
            this.gpuNameLabel.AutoSize = true;
            this.gpuNameLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuNameLabel.Location = new System.Drawing.Point(6, 6);
            this.gpuNameLabel.Name = "gpuNameLabel";
            this.gpuNameLabel.Size = new System.Drawing.Size(53, 23);
            this.gpuNameLabel.TabIndex = 3;
            this.gpuNameLabel.Text = "GPU: ";
            // 
            // gpuTemp
            // 
            this.gpuTemp.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.gpuTemp.AnimationSpeed = 200;
            this.gpuTemp.BackColor = System.Drawing.Color.Transparent;
            this.gpuTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gpuTemp.InnerColor = System.Drawing.Color.Empty;
            this.gpuTemp.InnerMargin = 2;
            this.gpuTemp.InnerWidth = -1;
            this.gpuTemp.Location = new System.Drawing.Point(42, 275);
            this.gpuTemp.MarqueeAnimationSpeed = 2000;
            this.gpuTemp.Name = "gpuTemp";
            this.gpuTemp.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(236)))), ((int)(((byte)(248)))));
            this.gpuTemp.OuterMargin = -25;
            this.gpuTemp.OuterWidth = 25;
            this.gpuTemp.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(130)))), ((int)(((byte)(190)))));
            this.gpuTemp.ProgressWidth = 16;
            this.gpuTemp.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.gpuTemp.Size = new System.Drawing.Size(160, 160);
            this.gpuTemp.StartAngle = 270;
            this.gpuTemp.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.gpuTemp.SubscriptMargin = new System.Windows.Forms.Padding(-10, 0, 0, 0);
            this.gpuTemp.SubscriptText = "";
            this.gpuTemp.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.gpuTemp.SuperscriptMargin = new System.Windows.Forms.Padding(11, 50, 0, 0);
            this.gpuTemp.SuperscriptText = "°C";
            this.gpuTemp.TabIndex = 4;
            this.gpuTemp.Text = "0";
            this.gpuTemp.TextMargin = new System.Windows.Forms.Padding(8, 30, 5, 50);
            this.gpuTemp.Value = 68;
            // 
            // gpuClockSpeed
            // 
            this.gpuClockSpeed.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.gpuClockSpeed.AnimationSpeed = 200;
            this.gpuClockSpeed.BackColor = System.Drawing.Color.Transparent;
            this.gpuClockSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuClockSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gpuClockSpeed.InnerColor = System.Drawing.Color.Empty;
            this.gpuClockSpeed.InnerMargin = 2;
            this.gpuClockSpeed.InnerWidth = -1;
            this.gpuClockSpeed.Location = new System.Drawing.Point(418, 275);
            this.gpuClockSpeed.MarqueeAnimationSpeed = 2000;
            this.gpuClockSpeed.Name = "gpuClockSpeed";
            this.gpuClockSpeed.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(236)))), ((int)(((byte)(248)))));
            this.gpuClockSpeed.OuterMargin = -25;
            this.gpuClockSpeed.OuterWidth = 25;
            this.gpuClockSpeed.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(130)))), ((int)(((byte)(190)))));
            this.gpuClockSpeed.ProgressWidth = 16;
            this.gpuClockSpeed.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.gpuClockSpeed.Size = new System.Drawing.Size(160, 160);
            this.gpuClockSpeed.StartAngle = 90;
            this.gpuClockSpeed.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.gpuClockSpeed.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.gpuClockSpeed.SubscriptText = "";
            this.gpuClockSpeed.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.gpuClockSpeed.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.gpuClockSpeed.SuperscriptText = "";
            this.gpuClockSpeed.TabIndex = 6;
            this.gpuClockSpeed.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.gpuClockSpeed.Value = 15;
            // 
            // gpuLoad
            // 
            this.gpuLoad.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.gpuLoad.AnimationSpeed = 200;
            this.gpuLoad.BackColor = System.Drawing.Color.Transparent;
            this.gpuLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gpuLoad.InnerColor = System.Drawing.Color.Empty;
            this.gpuLoad.InnerMargin = 2;
            this.gpuLoad.InnerWidth = -1;
            this.gpuLoad.Location = new System.Drawing.Point(230, 275);
            this.gpuLoad.MarqueeAnimationSpeed = 2000;
            this.gpuLoad.Name = "gpuLoad";
            this.gpuLoad.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(236)))), ((int)(((byte)(248)))));
            this.gpuLoad.OuterMargin = -25;
            this.gpuLoad.OuterWidth = 25;
            this.gpuLoad.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(130)))), ((int)(((byte)(190)))));
            this.gpuLoad.ProgressWidth = 16;
            this.gpuLoad.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.gpuLoad.Size = new System.Drawing.Size(160, 160);
            this.gpuLoad.StartAngle = 270;
            this.gpuLoad.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.gpuLoad.SubscriptMargin = new System.Windows.Forms.Padding(-10, 0, 0, 0);
            this.gpuLoad.SubscriptText = "";
            this.gpuLoad.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.gpuLoad.SuperscriptMargin = new System.Windows.Forms.Padding(5, 50, 0, 0);
            this.gpuLoad.SuperscriptText = "%";
            this.gpuLoad.TabIndex = 8;
            this.gpuLoad.Text = "0";
            this.gpuLoad.TextMargin = new System.Windows.Forms.Padding(8, 30, 10, 50);
            this.gpuLoad.Value = 68;
            // 
            // gpuTempLabel
            // 
            this.gpuTempLabel.AutoSize = true;
            this.gpuTempLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuTempLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.gpuTempLabel.Location = new System.Drawing.Point(99, 308);
            this.gpuTempLabel.Name = "gpuTempLabel";
            this.gpuTempLabel.Size = new System.Drawing.Size(58, 24);
            this.gpuTempLabel.TabIndex = 9;
            this.gpuTempLabel.Text = "TEMP";
            // 
            // gpuLoadLabel
            // 
            this.gpuLoadLabel.AutoSize = true;
            this.gpuLoadLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuLoadLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.gpuLoadLabel.Location = new System.Drawing.Point(284, 308);
            this.gpuLoadLabel.Name = "gpuLoadLabel";
            this.gpuLoadLabel.Size = new System.Drawing.Size(57, 24);
            this.gpuLoadLabel.TabIndex = 10;
            this.gpuLoadLabel.Text = "LOAD";
            // 
            // cpuLoad
            // 
            this.cpuLoad.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpuLoad.AnimationSpeed = 200;
            this.cpuLoad.BackColor = System.Drawing.Color.Transparent;
            this.cpuLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpuLoad.InnerColor = System.Drawing.Color.Empty;
            this.cpuLoad.InnerMargin = 2;
            this.cpuLoad.InnerWidth = -1;
            this.cpuLoad.Location = new System.Drawing.Point(230, 59);
            this.cpuLoad.MarqueeAnimationSpeed = 2000;
            this.cpuLoad.Name = "cpuLoad";
            this.cpuLoad.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(236)))), ((int)(((byte)(248)))));
            this.cpuLoad.OuterMargin = -25;
            this.cpuLoad.OuterWidth = 25;
            this.cpuLoad.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(130)))), ((int)(((byte)(190)))));
            this.cpuLoad.ProgressWidth = 16;
            this.cpuLoad.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.cpuLoad.Size = new System.Drawing.Size(160, 160);
            this.cpuLoad.StartAngle = 270;
            this.cpuLoad.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpuLoad.SubscriptMargin = new System.Windows.Forms.Padding(-10, 0, 0, 0);
            this.cpuLoad.SubscriptText = "";
            this.cpuLoad.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpuLoad.SuperscriptMargin = new System.Windows.Forms.Padding(5, 50, 0, 0);
            this.cpuLoad.SuperscriptText = "%";
            this.cpuLoad.TabIndex = 12;
            this.cpuLoad.Text = "0";
            this.cpuLoad.TextMargin = new System.Windows.Forms.Padding(8, 30, 10, 50);
            this.cpuLoad.Value = 68;
            // 
            // cpuTemp
            // 
            this.cpuTemp.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpuTemp.AnimationSpeed = 200;
            this.cpuTemp.BackColor = System.Drawing.Color.Transparent;
            this.cpuTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpuTemp.InnerColor = System.Drawing.Color.Empty;
            this.cpuTemp.InnerMargin = 2;
            this.cpuTemp.InnerWidth = -1;
            this.cpuTemp.Location = new System.Drawing.Point(42, 59);
            this.cpuTemp.MarqueeAnimationSpeed = 2000;
            this.cpuTemp.Name = "cpuTemp";
            this.cpuTemp.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(236)))), ((int)(((byte)(248)))));
            this.cpuTemp.OuterMargin = -25;
            this.cpuTemp.OuterWidth = 25;
            this.cpuTemp.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(130)))), ((int)(((byte)(190)))));
            this.cpuTemp.ProgressWidth = 16;
            this.cpuTemp.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.cpuTemp.Size = new System.Drawing.Size(160, 160);
            this.cpuTemp.StartAngle = 270;
            this.cpuTemp.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpuTemp.SubscriptMargin = new System.Windows.Forms.Padding(-10, 0, 0, 0);
            this.cpuTemp.SubscriptText = "";
            this.cpuTemp.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpuTemp.SuperscriptMargin = new System.Windows.Forms.Padding(11, 50, 0, 0);
            this.cpuTemp.SuperscriptText = "°C";
            this.cpuTemp.TabIndex = 11;
            this.cpuTemp.Text = "0";
            this.cpuTemp.TextMargin = new System.Windows.Forms.Padding(8, 30, 5, 50);
            this.cpuTemp.Value = 68;
            // 
            // cpuLoadLabel
            // 
            this.cpuLoadLabel.AutoSize = true;
            this.cpuLoadLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuLoadLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.cpuLoadLabel.Location = new System.Drawing.Point(284, 90);
            this.cpuLoadLabel.Name = "cpuLoadLabel";
            this.cpuLoadLabel.Size = new System.Drawing.Size(57, 24);
            this.cpuLoadLabel.TabIndex = 14;
            this.cpuLoadLabel.Text = "LOAD";
            // 
            // cpuTempLabel
            // 
            this.cpuTempLabel.AutoSize = true;
            this.cpuTempLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuTempLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.cpuTempLabel.Location = new System.Drawing.Point(99, 90);
            this.cpuTempLabel.Name = "cpuTempLabel";
            this.cpuTempLabel.Size = new System.Drawing.Size(58, 24);
            this.cpuTempLabel.TabIndex = 13;
            this.cpuTempLabel.Text = "TEMP";
            // 
            // gpuMhzPanel
            // 
            this.gpuMhzPanel.BackColor = System.Drawing.Color.Transparent;
            this.gpuMhzPanel.Controls.Add(this.gpuMHZLabel);
            this.gpuMhzPanel.Controls.Add(this.gpuClockSpeedText);
            this.gpuMhzPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gpuMhzPanel.Location = new System.Drawing.Point(418, 394);
            this.gpuMhzPanel.Name = "gpuMhzPanel";
            this.gpuMhzPanel.Size = new System.Drawing.Size(169, 43);
            this.gpuMhzPanel.TabIndex = 15;
            // 
            // gpuMHZLabel
            // 
            this.gpuMHZLabel.AutoSize = true;
            this.gpuMHZLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuMHZLabel.Location = new System.Drawing.Point(111, 27);
            this.gpuMHZLabel.Name = "gpuMHZLabel";
            this.gpuMHZLabel.Size = new System.Drawing.Size(38, 17);
            this.gpuMHZLabel.TabIndex = 18;
            this.gpuMHZLabel.Text = "MHZ";
            // 
            // gpuClockSpeedText
            // 
            this.gpuClockSpeedText.AutoSize = true;
            this.gpuClockSpeedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuClockSpeedText.Location = new System.Drawing.Point(25, 8);
            this.gpuClockSpeedText.Name = "gpuClockSpeedText";
            this.gpuClockSpeedText.Size = new System.Drawing.Size(93, 39);
            this.gpuClockSpeedText.TabIndex = 18;
            this.gpuClockSpeedText.Text = "1000";
            // 
            // gpuClockSpeedLbl
            // 
            this.gpuClockSpeedLbl.AutoSize = true;
            this.gpuClockSpeedLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuClockSpeedLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.gpuClockSpeedLbl.Location = new System.Drawing.Point(462, 383);
            this.gpuClockSpeedLbl.Name = "gpuClockSpeedLbl";
            this.gpuClockSpeedLbl.Size = new System.Drawing.Size(79, 17);
            this.gpuClockSpeedLbl.TabIndex = 17;
            this.gpuClockSpeedLbl.Text = "Clock Speed";
            // 
            // cpuClockSpeedLbl
            // 
            this.cpuClockSpeedLbl.AutoSize = true;
            this.cpuClockSpeedLbl.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuClockSpeedLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.cpuClockSpeedLbl.Location = new System.Drawing.Point(471, 167);
            this.cpuClockSpeedLbl.Name = "cpuClockSpeedLbl";
            this.cpuClockSpeedLbl.Size = new System.Drawing.Size(79, 17);
            this.cpuClockSpeedLbl.TabIndex = 20;
            this.cpuClockSpeedLbl.Text = "Clock Speed";
            // 
            // cpuMhzPanel
            // 
            this.cpuMhzPanel.BackColor = System.Drawing.Color.Transparent;
            this.cpuMhzPanel.Controls.Add(this.cpuMHZLabel);
            this.cpuMhzPanel.Controls.Add(this.cpuClockSpeedText);
            this.cpuMhzPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cpuMhzPanel.Location = new System.Drawing.Point(427, 178);
            this.cpuMhzPanel.Name = "cpuMhzPanel";
            this.cpuMhzPanel.Size = new System.Drawing.Size(169, 43);
            this.cpuMhzPanel.TabIndex = 19;
            // 
            // cpuMHZLabel
            // 
            this.cpuMHZLabel.AutoSize = true;
            this.cpuMHZLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuMHZLabel.Location = new System.Drawing.Point(111, 27);
            this.cpuMHZLabel.Name = "cpuMHZLabel";
            this.cpuMHZLabel.Size = new System.Drawing.Size(38, 17);
            this.cpuMHZLabel.TabIndex = 18;
            this.cpuMHZLabel.Text = "MHZ";
            // 
            // cpuClockSpeedText
            // 
            this.cpuClockSpeedText.AutoSize = true;
            this.cpuClockSpeedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuClockSpeedText.Location = new System.Drawing.Point(25, 8);
            this.cpuClockSpeedText.Name = "cpuClockSpeedText";
            this.cpuClockSpeedText.Size = new System.Drawing.Size(93, 39);
            this.cpuClockSpeedText.TabIndex = 18;
            this.cpuClockSpeedText.Text = "1000";
            // 
            // cpuClockSpeed
            // 
            this.cpuClockSpeed.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpuClockSpeed.AnimationSpeed = 300;
            this.cpuClockSpeed.BackColor = System.Drawing.Color.Transparent;
            this.cpuClockSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuClockSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpuClockSpeed.InnerColor = System.Drawing.Color.Empty;
            this.cpuClockSpeed.InnerMargin = 2;
            this.cpuClockSpeed.InnerWidth = -1;
            this.cpuClockSpeed.Location = new System.Drawing.Point(427, 59);
            this.cpuClockSpeed.MarqueeAnimationSpeed = 2000;
            this.cpuClockSpeed.Name = "cpuClockSpeed";
            this.cpuClockSpeed.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(236)))), ((int)(((byte)(248)))));
            this.cpuClockSpeed.OuterMargin = -25;
            this.cpuClockSpeed.OuterWidth = 25;
            this.cpuClockSpeed.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(130)))), ((int)(((byte)(190)))));
            this.cpuClockSpeed.ProgressWidth = 16;
            this.cpuClockSpeed.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cpuClockSpeed.Size = new System.Drawing.Size(160, 160);
            this.cpuClockSpeed.StartAngle = 90;
            this.cpuClockSpeed.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpuClockSpeed.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpuClockSpeed.SubscriptText = "";
            this.cpuClockSpeed.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpuClockSpeed.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpuClockSpeed.SuperscriptText = "";
            this.cpuClockSpeed.TabIndex = 18;
            this.cpuClockSpeed.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpuClockSpeed.Value = 15;
            // 
            // gpuFanLabel
            // 
            this.gpuFanLabel.AutoSize = true;
            this.gpuFanLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuFanLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.gpuFanLabel.Location = new System.Drawing.Point(668, 308);
            this.gpuFanLabel.Name = "gpuFanLabel";
            this.gpuFanLabel.Size = new System.Drawing.Size(43, 24);
            this.gpuFanLabel.TabIndex = 22;
            this.gpuFanLabel.Text = "FAN";
            // 
            // gpuFan
            // 
            this.gpuFan.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.gpuFan.AnimationSpeed = 200;
            this.gpuFan.BackColor = System.Drawing.Color.Transparent;
            this.gpuFan.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpuFan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gpuFan.InnerColor = System.Drawing.Color.Empty;
            this.gpuFan.InnerMargin = 2;
            this.gpuFan.InnerWidth = -1;
            this.gpuFan.Location = new System.Drawing.Point(606, 275);
            this.gpuFan.MarqueeAnimationSpeed = 2000;
            this.gpuFan.Name = "gpuFan";
            this.gpuFan.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(236)))), ((int)(((byte)(248)))));
            this.gpuFan.OuterMargin = -25;
            this.gpuFan.OuterWidth = 25;
            this.gpuFan.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(130)))), ((int)(((byte)(190)))));
            this.gpuFan.ProgressWidth = 16;
            this.gpuFan.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.gpuFan.Size = new System.Drawing.Size(160, 160);
            this.gpuFan.StartAngle = 270;
            this.gpuFan.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.gpuFan.SubscriptMargin = new System.Windows.Forms.Padding(-10, 0, 0, 0);
            this.gpuFan.SubscriptText = "";
            this.gpuFan.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.gpuFan.SuperscriptMargin = new System.Windows.Forms.Padding(5, 50, 0, 0);
            this.gpuFan.SuperscriptText = "%";
            this.gpuFan.TabIndex = 21;
            this.gpuFan.Text = "0";
            this.gpuFan.TextMargin = new System.Windows.Forms.Padding(8, 30, 10, 50);
            this.gpuFan.Value = 68;
            // 
            // cpuPanel
            // 
            this.cpuPanel.BackColor = System.Drawing.Color.Transparent;
            this.cpuPanel.Controls.Add(this.cpuNameLabel);
            this.cpuPanel.Location = new System.Drawing.Point(27, 19);
            this.cpuPanel.Name = "cpuPanel";
            this.cpuPanel.Size = new System.Drawing.Size(573, 214);
            this.cpuPanel.TabIndex = 26;
            this.cpuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BorderPanels_Paint);
            // 
            // gpuPanel
            // 
            this.gpuPanel.BackColor = System.Drawing.Color.Transparent;
            this.gpuPanel.Controls.Add(this.gpuNameLabel);
            this.gpuPanel.Location = new System.Drawing.Point(27, 236);
            this.gpuPanel.Name = "gpuPanel";
            this.gpuPanel.Size = new System.Drawing.Size(748, 214);
            this.gpuPanel.TabIndex = 27;
            this.gpuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BorderPanels_Paint);
            // 
            // ramPanel
            // 
            this.ramPanel.BackColor = System.Drawing.Color.Transparent;
            this.ramPanel.Controls.Add(this.label1);
            this.ramPanel.Controls.Add(this.ramGB);
            this.ramPanel.Controls.Add(this.vRamLoad);
            this.ramPanel.Controls.Add(this.ramLoad);
            this.ramPanel.Controls.Add(this.ramVramLabel);
            this.ramPanel.Location = new System.Drawing.Point(603, 19);
            this.ramPanel.Name = "ramPanel";
            this.ramPanel.Size = new System.Drawing.Size(172, 230);
            this.ramPanel.TabIndex = 37;
            this.ramPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.BorderPanels_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.label1.Location = new System.Drawing.Point(110, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "GB";
            // 
            // ramGB
            // 
            this.ramGB.AutoSize = true;
            this.ramGB.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.ramGB.Location = new System.Drawing.Point(44, 99);
            this.ramGB.Name = "ramGB";
            this.ramGB.Size = new System.Drawing.Size(20, 13);
            this.ramGB.TabIndex = 26;
            this.ramGB.Text = "GB";
            // 
            // vRamLoad
            // 
            this.vRamLoad.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.vRamLoad.AnimationSpeed = 200;
            this.vRamLoad.BackColor = System.Drawing.Color.Transparent;
            this.vRamLoad.Font = new System.Drawing.Font("Calibri", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vRamLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.vRamLoad.InnerColor = System.Drawing.Color.Empty;
            this.vRamLoad.InnerMargin = 2;
            this.vRamLoad.InnerWidth = -1;
            this.vRamLoad.Location = new System.Drawing.Point(69, 127);
            this.vRamLoad.MarqueeAnimationSpeed = 2000;
            this.vRamLoad.Name = "vRamLoad";
            this.vRamLoad.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(236)))), ((int)(((byte)(248)))));
            this.vRamLoad.OuterMargin = -25;
            this.vRamLoad.OuterWidth = 25;
            this.vRamLoad.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(130)))), ((int)(((byte)(190)))));
            this.vRamLoad.ProgressWidth = 11;
            this.vRamLoad.SecondaryFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.vRamLoad.Size = new System.Drawing.Size(100, 100);
            this.vRamLoad.StartAngle = 270;
            this.vRamLoad.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.vRamLoad.SubscriptMargin = new System.Windows.Forms.Padding(-22, 12, 0, 0);
            this.vRamLoad.SubscriptText = "";
            this.vRamLoad.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.vRamLoad.SuperscriptMargin = new System.Windows.Forms.Padding(5, 27, 0, 0);
            this.vRamLoad.SuperscriptText = "";
            this.vRamLoad.TabIndex = 25;
            this.vRamLoad.Text = "00.00";
            this.vRamLoad.TextMargin = new System.Windows.Forms.Padding(6, 20, 8, 40);
            this.vRamLoad.Value = 68;
            // 
            // ramLoad
            // 
            this.ramLoad.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.ramLoad.AnimationSpeed = 200;
            this.ramLoad.BackColor = System.Drawing.Color.Transparent;
            this.ramLoad.Font = new System.Drawing.Font("Calibri", 21F);
            this.ramLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.ramLoad.InnerColor = System.Drawing.Color.Empty;
            this.ramLoad.InnerMargin = 2;
            this.ramLoad.InnerWidth = -1;
            this.ramLoad.Location = new System.Drawing.Point(3, 30);
            this.ramLoad.MarqueeAnimationSpeed = 2000;
            this.ramLoad.Name = "ramLoad";
            this.ramLoad.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(236)))), ((int)(((byte)(248)))));
            this.ramLoad.OuterMargin = -25;
            this.ramLoad.OuterWidth = 25;
            this.ramLoad.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(130)))), ((int)(((byte)(190)))));
            this.ramLoad.ProgressWidth = 11;
            this.ramLoad.SecondaryFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramLoad.Size = new System.Drawing.Size(100, 100);
            this.ramLoad.StartAngle = 270;
            this.ramLoad.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ramLoad.SubscriptMargin = new System.Windows.Forms.Padding(-22, 12, 0, 0);
            this.ramLoad.SubscriptText = "";
            this.ramLoad.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.ramLoad.SuperscriptMargin = new System.Windows.Forms.Padding(5, 27, 0, 0);
            this.ramLoad.SuperscriptText = "";
            this.ramLoad.TabIndex = 24;
            this.ramLoad.Text = "00.00";
            this.ramLoad.TextMargin = new System.Windows.Forms.Padding(6, 20, 8, 40);
            this.ramLoad.Value = 68;
            // 
            // ramVramLabel
            // 
            this.ramVramLabel.AutoSize = true;
            this.ramVramLabel.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramVramLabel.Location = new System.Drawing.Point(3, 4);
            this.ramVramLabel.Name = "ramVramLabel";
            this.ramVramLabel.Size = new System.Drawing.Size(117, 23);
            this.ramVramLabel.TabIndex = 23;
            this.ramVramLabel.Text = "RAM / VRAM";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 463);
            this.Controls.Add(this.ramPanel);
            this.Controls.Add(this.gpuFanLabel);
            this.Controls.Add(this.gpuFan);
            this.Controls.Add(this.cpuClockSpeedLbl);
            this.Controls.Add(this.cpuMhzPanel);
            this.Controls.Add(this.cpuClockSpeed);
            this.Controls.Add(this.gpuClockSpeedLbl);
            this.Controls.Add(this.gpuMhzPanel);
            this.Controls.Add(this.cpuLoadLabel);
            this.Controls.Add(this.cpuTempLabel);
            this.Controls.Add(this.cpuLoad);
            this.Controls.Add(this.cpuTemp);
            this.Controls.Add(this.gpuLoadLabel);
            this.Controls.Add(this.gpuTempLabel);
            this.Controls.Add(this.gpuLoad);
            this.Controls.Add(this.gpuTemp);
            this.Controls.Add(this.gpuClockSpeed);
            this.Controls.Add(this.cpuPanel);
            this.Controls.Add(this.gpuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "HWStats";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserExit);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindowKeyDown);
            this.gpuMhzPanel.ResumeLayout(false);
            this.gpuMhzPanel.PerformLayout();
            this.cpuMhzPanel.ResumeLayout(false);
            this.cpuMhzPanel.PerformLayout();
            this.cpuPanel.ResumeLayout(false);
            this.cpuPanel.PerformLayout();
            this.gpuPanel.ResumeLayout(false);
            this.gpuPanel.PerformLayout();
            this.ramPanel.ResumeLayout(false);
            this.ramPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cpuNameLabel;
        private System.Windows.Forms.Label gpuNameLabel;
        private CircularProgressBar.CircularProgressBar gpuTemp;
        private CircularProgressBar.CircularProgressBar gpuClockSpeed;
        private CircularProgressBar.CircularProgressBar gpuLoad;
        private System.Windows.Forms.Label gpuTempLabel;
        private System.Windows.Forms.Label gpuLoadLabel;
        private CircularProgressBar.CircularProgressBar cpuLoad;
        private CircularProgressBar.CircularProgressBar cpuTemp;
        private System.Windows.Forms.Label cpuLoadLabel;
        private System.Windows.Forms.Label cpuTempLabel;
        private System.Windows.Forms.Panel gpuMhzPanel;
        private System.Windows.Forms.Label gpuClockSpeedLbl;
        private System.Windows.Forms.Label gpuClockSpeedText;
        private System.Windows.Forms.Label gpuMHZLabel;
        private System.Windows.Forms.Label cpuClockSpeedLbl;
        private System.Windows.Forms.Panel cpuMhzPanel;
        private System.Windows.Forms.Label cpuMHZLabel;
        private System.Windows.Forms.Label cpuClockSpeedText;
        private CircularProgressBar.CircularProgressBar cpuClockSpeed;
        private System.Windows.Forms.Label gpuFanLabel;
        private CircularProgressBar.CircularProgressBar gpuFan;
        private System.Windows.Forms.Panel cpuPanel;
        private System.Windows.Forms.Panel gpuPanel;
        private System.Windows.Forms.Panel ramPanel;
        private System.Windows.Forms.Label ramVramLabel;
        private CircularProgressBar.CircularProgressBar ramLoad;
        private CircularProgressBar.CircularProgressBar vRamLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ramGB;
    }
}

