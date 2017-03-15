namespace RocketPi
{
    partial class RocketPi_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RocketPi_Form));
            this.consoleGroup = new System.Windows.Forms.GroupBox();
            this.statusGroup = new System.Windows.Forms.GroupBox();
            this.portStatusText = new System.Windows.Forms.TextBox();
            this.portSwitchButton = new System.Windows.Forms.Button();
            this.currentPortGroup = new System.Windows.Forms.GroupBox();
            this.portScanButton = new System.Windows.Forms.Button();
            this.currentPortText = new System.Windows.Forms.TextBox();
            this.consoleClearButton = new System.Windows.Forms.Button();
            this.sendConsoleInputButton = new System.Windows.Forms.Button();
            this.consoleInput = new System.Windows.Forms.TextBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.gpsDataGroup = new System.Windows.Forms.GroupBox();
            this.gpsLongGroup = new System.Windows.Forms.GroupBox();
            this.gpsLongText = new System.Windows.Forms.TextBox();
            this.gpsLatGroup = new System.Windows.Forms.GroupBox();
            this.gpsLatText = new System.Windows.Forms.TextBox();
            this.gpsValidityGroup = new System.Windows.Forms.GroupBox();
            this.gpsValidityText = new System.Windows.Forms.TextBox();
            this.gpsTimeStampGroup = new System.Windows.Forms.GroupBox();
            this.gpsTimeStampText = new System.Windows.Forms.TextBox();
            this.topMenuStrip = new System.Windows.Forms.MenuStrip();
            this.settingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.presetMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.presetRaspberryPi = new System.Windows.Forms.ToolStripMenuItem();
            this.presetXbee = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.portMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.portCom1 = new System.Windows.Forms.ToolStripMenuItem();
            this.portCom2 = new System.Windows.Forms.ToolStripMenuItem();
            this.portCom3 = new System.Windows.Forms.ToolStripMenuItem();
            this.portCom4 = new System.Windows.Forms.ToolStripMenuItem();
            this.portCom5 = new System.Windows.Forms.ToolStripMenuItem();
            this.portCom6 = new System.Windows.Forms.ToolStripMenuItem();
            this.portCom7 = new System.Windows.Forms.ToolStripMenuItem();
            this.portCom8 = new System.Windows.Forms.ToolStripMenuItem();
            this.rocketpiToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gpsTabControl = new System.Windows.Forms.TabControl();
            this.gpsMapTabPage = new System.Windows.Forms.TabPage();
            this.gpsMap = new GMap.NET.WindowsForms.GMapControl();
            this.gpsDataTabPage = new System.Windows.Forms.TabPage();
            this.consoleText = new System.Windows.Forms.RichTextBox();
            this.consoleGroup.SuspendLayout();
            this.statusGroup.SuspendLayout();
            this.currentPortGroup.SuspendLayout();
            this.gpsDataGroup.SuspendLayout();
            this.gpsLongGroup.SuspendLayout();
            this.gpsLatGroup.SuspendLayout();
            this.gpsValidityGroup.SuspendLayout();
            this.gpsTimeStampGroup.SuspendLayout();
            this.topMenuStrip.SuspendLayout();
            this.gpsTabControl.SuspendLayout();
            this.gpsMapTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // consoleGroup
            // 
            this.consoleGroup.Controls.Add(this.consoleText);
            this.consoleGroup.Controls.Add(this.statusGroup);
            this.consoleGroup.Controls.Add(this.currentPortGroup);
            this.consoleGroup.Controls.Add(this.consoleClearButton);
            this.consoleGroup.Controls.Add(this.sendConsoleInputButton);
            this.consoleGroup.Controls.Add(this.consoleInput);
            this.consoleGroup.Location = new System.Drawing.Point(12, 38);
            this.consoleGroup.Margin = new System.Windows.Forms.Padding(10);
            this.consoleGroup.Name = "consoleGroup";
            this.consoleGroup.Padding = new System.Windows.Forms.Padding(5);
            this.consoleGroup.Size = new System.Drawing.Size(958, 317);
            this.consoleGroup.TabIndex = 1;
            this.consoleGroup.TabStop = false;
            this.consoleGroup.Text = "Console";
            // 
            // statusGroup
            // 
            this.statusGroup.Controls.Add(this.portStatusText);
            this.statusGroup.Controls.Add(this.portSwitchButton);
            this.statusGroup.Location = new System.Drawing.Point(811, 100);
            this.statusGroup.Name = "statusGroup";
            this.statusGroup.Size = new System.Drawing.Size(140, 74);
            this.statusGroup.TabIndex = 6;
            this.statusGroup.TabStop = false;
            this.statusGroup.Text = "Port Status";
            // 
            // portStatusText
            // 
            this.portStatusText.BackColor = System.Drawing.SystemColors.Control;
            this.portStatusText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.portStatusText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.portStatusText.Location = new System.Drawing.Point(9, 22);
            this.portStatusText.Name = "portStatusText";
            this.portStatusText.ReadOnly = true;
            this.portStatusText.Size = new System.Drawing.Size(125, 15);
            this.portStatusText.TabIndex = 2;
            this.portStatusText.Text = "CLOSED";
            this.portStatusText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // portSwitchButton
            // 
            this.portSwitchButton.Location = new System.Drawing.Point(6, 43);
            this.portSwitchButton.Name = "portSwitchButton";
            this.portSwitchButton.Size = new System.Drawing.Size(128, 23);
            this.portSwitchButton.TabIndex = 1;
            this.portSwitchButton.Text = "Open";
            this.portSwitchButton.UseVisualStyleBackColor = true;
            this.portSwitchButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.portSwitch);
            // 
            // currentPortGroup
            // 
            this.currentPortGroup.Controls.Add(this.portScanButton);
            this.currentPortGroup.Controls.Add(this.currentPortText);
            this.currentPortGroup.Location = new System.Drawing.Point(811, 20);
            this.currentPortGroup.Name = "currentPortGroup";
            this.currentPortGroup.Size = new System.Drawing.Size(140, 74);
            this.currentPortGroup.TabIndex = 5;
            this.currentPortGroup.TabStop = false;
            this.currentPortGroup.Text = "Current Port";
            // 
            // portScanButton
            // 
            this.portScanButton.Location = new System.Drawing.Point(9, 43);
            this.portScanButton.Name = "portScanButton";
            this.portScanButton.Size = new System.Drawing.Size(125, 23);
            this.portScanButton.TabIndex = 1;
            this.portScanButton.Text = "Scan";
            this.portScanButton.UseVisualStyleBackColor = true;
            this.portScanButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.scanPort);
            // 
            // currentPortText
            // 
            this.currentPortText.BackColor = System.Drawing.SystemColors.Control;
            this.currentPortText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentPortText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.currentPortText.Location = new System.Drawing.Point(9, 22);
            this.currentPortText.Name = "currentPortText";
            this.currentPortText.ReadOnly = true;
            this.currentPortText.Size = new System.Drawing.Size(125, 15);
            this.currentPortText.TabIndex = 0;
            this.currentPortText.Text = "N/A";
            this.currentPortText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // consoleClearButton
            // 
            this.consoleClearButton.Location = new System.Drawing.Point(817, 247);
            this.consoleClearButton.Name = "consoleClearButton";
            this.consoleClearButton.Size = new System.Drawing.Size(128, 24);
            this.consoleClearButton.TabIndex = 4;
            this.consoleClearButton.Text = "Clear Console";
            this.consoleClearButton.UseVisualStyleBackColor = true;
            this.consoleClearButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Console_Clear);
            // 
            // sendConsoleInputButton
            // 
            this.sendConsoleInputButton.Location = new System.Drawing.Point(817, 284);
            this.sendConsoleInputButton.Name = "sendConsoleInputButton";
            this.sendConsoleInputButton.Size = new System.Drawing.Size(128, 24);
            this.sendConsoleInputButton.TabIndex = 3;
            this.sendConsoleInputButton.Text = "Send";
            this.sendConsoleInputButton.UseVisualStyleBackColor = true;
            this.sendConsoleInputButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.writeToPortButton);
            // 
            // consoleInput
            // 
            this.consoleInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(111)))));
            this.consoleInput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(211)))), ((int)(((byte)(162)))));
            this.consoleInput.Location = new System.Drawing.Point(5, 277);
            this.consoleInput.Name = "consoleInput";
            this.consoleInput.Size = new System.Drawing.Size(800, 31);
            this.consoleInput.TabIndex = 1;
            this.consoleInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.writeToPortTextbox);
            // 
            // gpsDataGroup
            // 
            this.gpsDataGroup.Controls.Add(this.gpsLongGroup);
            this.gpsDataGroup.Controls.Add(this.gpsLatGroup);
            this.gpsDataGroup.Controls.Add(this.gpsValidityGroup);
            this.gpsDataGroup.Controls.Add(this.gpsTimeStampGroup);
            this.gpsDataGroup.Location = new System.Drawing.Point(12, 361);
            this.gpsDataGroup.Name = "gpsDataGroup";
            this.gpsDataGroup.Size = new System.Drawing.Size(129, 380);
            this.gpsDataGroup.TabIndex = 8;
            this.gpsDataGroup.TabStop = false;
            this.gpsDataGroup.Text = "GPS Data";
            // 
            // gpsLongGroup
            // 
            this.gpsLongGroup.Controls.Add(this.gpsLongText);
            this.gpsLongGroup.Location = new System.Drawing.Point(5, 184);
            this.gpsLongGroup.Name = "gpsLongGroup";
            this.gpsLongGroup.Size = new System.Drawing.Size(115, 48);
            this.gpsLongGroup.TabIndex = 3;
            this.gpsLongGroup.TabStop = false;
            this.gpsLongGroup.Text = "Longtitude";
            this.rocketpiToolTip.SetToolTip(this.gpsLongGroup, "Longitude of fix");
            // 
            // gpsLongText
            // 
            this.gpsLongText.BackColor = System.Drawing.SystemColors.Control;
            this.gpsLongText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gpsLongText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.gpsLongText.Location = new System.Drawing.Point(6, 21);
            this.gpsLongText.Name = "gpsLongText";
            this.gpsLongText.ReadOnly = true;
            this.gpsLongText.Size = new System.Drawing.Size(103, 15);
            this.gpsLongText.TabIndex = 0;
            this.gpsLongText.Text = "N/A";
            this.gpsLongText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rocketpiToolTip.SetToolTip(this.gpsLongText, "Longitude of fix");
            // 
            // gpsLatGroup
            // 
            this.gpsLatGroup.Controls.Add(this.gpsLatText);
            this.gpsLatGroup.Location = new System.Drawing.Point(5, 130);
            this.gpsLatGroup.Name = "gpsLatGroup";
            this.gpsLatGroup.Size = new System.Drawing.Size(115, 48);
            this.gpsLatGroup.TabIndex = 2;
            this.gpsLatGroup.TabStop = false;
            this.gpsLatGroup.Text = "Latitude";
            this.rocketpiToolTip.SetToolTip(this.gpsLatGroup, "Latitude of fix");
            // 
            // gpsLatText
            // 
            this.gpsLatText.BackColor = System.Drawing.SystemColors.Control;
            this.gpsLatText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gpsLatText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.gpsLatText.Location = new System.Drawing.Point(6, 21);
            this.gpsLatText.Name = "gpsLatText";
            this.gpsLatText.ReadOnly = true;
            this.gpsLatText.Size = new System.Drawing.Size(103, 15);
            this.gpsLatText.TabIndex = 0;
            this.gpsLatText.Text = "N/A";
            this.gpsLatText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rocketpiToolTip.SetToolTip(this.gpsLatText, "Latitude of fix");
            // 
            // gpsValidityGroup
            // 
            this.gpsValidityGroup.Controls.Add(this.gpsValidityText);
            this.gpsValidityGroup.Location = new System.Drawing.Point(5, 76);
            this.gpsValidityGroup.Name = "gpsValidityGroup";
            this.gpsValidityGroup.Size = new System.Drawing.Size(115, 48);
            this.gpsValidityGroup.TabIndex = 1;
            this.gpsValidityGroup.TabStop = false;
            this.gpsValidityGroup.Text = "Validity";
            this.rocketpiToolTip.SetToolTip(this.gpsValidityGroup, "Data status (A = ok, V = navigation receiver warning)");
            // 
            // gpsValidityText
            // 
            this.gpsValidityText.BackColor = System.Drawing.SystemColors.Control;
            this.gpsValidityText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gpsValidityText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.gpsValidityText.Location = new System.Drawing.Point(6, 21);
            this.gpsValidityText.Name = "gpsValidityText";
            this.gpsValidityText.ReadOnly = true;
            this.gpsValidityText.Size = new System.Drawing.Size(103, 15);
            this.gpsValidityText.TabIndex = 0;
            this.gpsValidityText.Text = "V";
            this.gpsValidityText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rocketpiToolTip.SetToolTip(this.gpsValidityText, "Data status (A = ok, V = navigation receiver warning)");
            // 
            // gpsTimeStampGroup
            // 
            this.gpsTimeStampGroup.Controls.Add(this.gpsTimeStampText);
            this.gpsTimeStampGroup.Location = new System.Drawing.Point(5, 22);
            this.gpsTimeStampGroup.Name = "gpsTimeStampGroup";
            this.gpsTimeStampGroup.Size = new System.Drawing.Size(115, 48);
            this.gpsTimeStampGroup.TabIndex = 0;
            this.gpsTimeStampGroup.TabStop = false;
            this.gpsTimeStampGroup.Text = "Timestamp";
            this.rocketpiToolTip.SetToolTip(this.gpsTimeStampGroup, "UTC of position fix");
            // 
            // gpsTimeStampText
            // 
            this.gpsTimeStampText.BackColor = System.Drawing.SystemColors.Control;
            this.gpsTimeStampText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gpsTimeStampText.Location = new System.Drawing.Point(6, 21);
            this.gpsTimeStampText.Name = "gpsTimeStampText";
            this.gpsTimeStampText.ReadOnly = true;
            this.gpsTimeStampText.Size = new System.Drawing.Size(103, 15);
            this.gpsTimeStampText.TabIndex = 0;
            this.gpsTimeStampText.Text = "N/A";
            this.gpsTimeStampText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rocketpiToolTip.SetToolTip(this.gpsTimeStampText, "UTC of position fix");
            // 
            // topMenuStrip
            // 
            this.topMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.topMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsMenu});
            this.topMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.topMenuStrip.Name = "topMenuStrip";
            this.topMenuStrip.Size = new System.Drawing.Size(982, 28);
            this.topMenuStrip.TabIndex = 9;
            this.topMenuStrip.Text = "menuStrip";
            // 
            // settingsMenu
            // 
            this.settingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.presetMenu,
            this.toolStripSeparator1,
            this.portMenu});
            this.settingsMenu.Name = "settingsMenu";
            this.settingsMenu.Size = new System.Drawing.Size(74, 24);
            this.settingsMenu.Text = "Settings";
            // 
            // presetMenu
            // 
            this.presetMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.presetRaspberryPi,
            this.presetXbee});
            this.presetMenu.Name = "presetMenu";
            this.presetMenu.Size = new System.Drawing.Size(124, 26);
            this.presetMenu.Text = "Preset";
            // 
            // presetRaspberryPi
            // 
            this.presetRaspberryPi.Name = "presetRaspberryPi";
            this.presetRaspberryPi.Size = new System.Drawing.Size(166, 26);
            this.presetRaspberryPi.Text = "Raspberry Pi";
            this.presetRaspberryPi.Click += new System.EventHandler(this.settingsMenuOnClick);
            // 
            // presetXbee
            // 
            this.presetXbee.Checked = true;
            this.presetXbee.CheckState = System.Windows.Forms.CheckState.Checked;
            this.presetXbee.Name = "presetXbee";
            this.presetXbee.Size = new System.Drawing.Size(166, 26);
            this.presetXbee.Text = "XBee ";
            this.presetXbee.Click += new System.EventHandler(this.settingsMenuOnClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // portMenu
            // 
            this.portMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portCom1,
            this.portCom2,
            this.portCom3,
            this.portCom4,
            this.portCom5,
            this.portCom6,
            this.portCom7,
            this.portCom8});
            this.portMenu.Name = "portMenu";
            this.portMenu.Size = new System.Drawing.Size(124, 26);
            this.portMenu.Text = "Port";
            // 
            // portCom1
            // 
            this.portCom1.Name = "portCom1";
            this.portCom1.Size = new System.Drawing.Size(125, 26);
            this.portCom1.Text = "COM1";
            this.portCom1.Click += new System.EventHandler(this.settingsMenuOnClick);
            // 
            // portCom2
            // 
            this.portCom2.Name = "portCom2";
            this.portCom2.Size = new System.Drawing.Size(125, 26);
            this.portCom2.Text = "COM2";
            this.portCom2.Click += new System.EventHandler(this.settingsMenuOnClick);
            // 
            // portCom3
            // 
            this.portCom3.Name = "portCom3";
            this.portCom3.Size = new System.Drawing.Size(125, 26);
            this.portCom3.Text = "COM3";
            this.portCom3.Click += new System.EventHandler(this.settingsMenuOnClick);
            // 
            // portCom4
            // 
            this.portCom4.Name = "portCom4";
            this.portCom4.Size = new System.Drawing.Size(125, 26);
            this.portCom4.Text = "COM4";
            this.portCom4.Click += new System.EventHandler(this.settingsMenuOnClick);
            // 
            // portCom5
            // 
            this.portCom5.Name = "portCom5";
            this.portCom5.Size = new System.Drawing.Size(125, 26);
            this.portCom5.Text = "COM5";
            this.portCom5.Click += new System.EventHandler(this.settingsMenuOnClick);
            // 
            // portCom6
            // 
            this.portCom6.Name = "portCom6";
            this.portCom6.Size = new System.Drawing.Size(125, 26);
            this.portCom6.Text = "COM6";
            this.portCom6.Click += new System.EventHandler(this.settingsMenuOnClick);
            // 
            // portCom7
            // 
            this.portCom7.Name = "portCom7";
            this.portCom7.Size = new System.Drawing.Size(125, 26);
            this.portCom7.Text = "COM7";
            this.portCom7.Click += new System.EventHandler(this.settingsMenuOnClick);
            // 
            // portCom8
            // 
            this.portCom8.Name = "portCom8";
            this.portCom8.Size = new System.Drawing.Size(125, 26);
            this.portCom8.Text = "COM8";
            this.portCom8.Click += new System.EventHandler(this.settingsMenuOnClick);
            // 
            // gpsTabControl
            // 
            this.gpsTabControl.Controls.Add(this.gpsMapTabPage);
            this.gpsTabControl.Controls.Add(this.gpsDataTabPage);
            this.gpsTabControl.Location = new System.Drawing.Point(148, 369);
            this.gpsTabControl.Name = "gpsTabControl";
            this.gpsTabControl.SelectedIndex = 0;
            this.gpsTabControl.Size = new System.Drawing.Size(822, 372);
            this.gpsTabControl.TabIndex = 10;
            // 
            // gpsMapTabPage
            // 
            this.gpsMapTabPage.Controls.Add(this.gpsMap);
            this.gpsMapTabPage.Location = new System.Drawing.Point(4, 25);
            this.gpsMapTabPage.Name = "gpsMapTabPage";
            this.gpsMapTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.gpsMapTabPage.Size = new System.Drawing.Size(814, 343);
            this.gpsMapTabPage.TabIndex = 0;
            this.gpsMapTabPage.Text = "Map";
            this.gpsMapTabPage.UseVisualStyleBackColor = true;
            // 
            // gpsMap
            // 
            this.gpsMap.Bearing = 0F;
            this.gpsMap.CanDragMap = true;
            this.gpsMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpsMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gpsMap.GrayScaleMode = false;
            this.gpsMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gpsMap.LevelsKeepInMemmory = 5;
            this.gpsMap.Location = new System.Drawing.Point(3, 3);
            this.gpsMap.MarkersEnabled = true;
            this.gpsMap.MaxZoom = 18;
            this.gpsMap.MinZoom = 0;
            this.gpsMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gpsMap.Name = "gpsMap";
            this.gpsMap.NegativeMode = false;
            this.gpsMap.PolygonsEnabled = true;
            this.gpsMap.RetryLoadTile = 0;
            this.gpsMap.RoutesEnabled = true;
            this.gpsMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gpsMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gpsMap.ShowTileGridLines = false;
            this.gpsMap.Size = new System.Drawing.Size(808, 337);
            this.gpsMap.TabIndex = 0;
            this.gpsMap.Zoom = 15D;
            // 
            // gpsDataTabPage
            // 
            this.gpsDataTabPage.Location = new System.Drawing.Point(4, 25);
            this.gpsDataTabPage.Name = "gpsDataTabPage";
            this.gpsDataTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.gpsDataTabPage.Size = new System.Drawing.Size(814, 343);
            this.gpsDataTabPage.TabIndex = 1;
            this.gpsDataTabPage.Text = "Data";
            this.gpsDataTabPage.UseVisualStyleBackColor = true;
            // 
            // consoleText
            // 
            this.consoleText.Location = new System.Drawing.Point(8, 23);
            this.consoleText.Name = "consoleText";
            this.consoleText.ReadOnly = true;
            this.consoleText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.consoleText.Size = new System.Drawing.Size(797, 248);
            this.consoleText.TabIndex = 7;
            this.consoleText.Text = "";
            // 
            // RocketPi_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.gpsTabControl);
            this.Controls.Add(this.gpsDataGroup);
            this.Controls.Add(this.consoleGroup);
            this.Controls.Add(this.topMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.topMenuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "RocketPi_Form";
            this.Text = "RocketPi - GPS";
            this.Load += new System.EventHandler(this.mainWindowLoad);
            this.consoleGroup.ResumeLayout(false);
            this.consoleGroup.PerformLayout();
            this.statusGroup.ResumeLayout(false);
            this.statusGroup.PerformLayout();
            this.currentPortGroup.ResumeLayout(false);
            this.currentPortGroup.PerformLayout();
            this.gpsDataGroup.ResumeLayout(false);
            this.gpsLongGroup.ResumeLayout(false);
            this.gpsLongGroup.PerformLayout();
            this.gpsLatGroup.ResumeLayout(false);
            this.gpsLatGroup.PerformLayout();
            this.gpsValidityGroup.ResumeLayout(false);
            this.gpsValidityGroup.PerformLayout();
            this.gpsTimeStampGroup.ResumeLayout(false);
            this.gpsTimeStampGroup.PerformLayout();
            this.topMenuStrip.ResumeLayout(false);
            this.topMenuStrip.PerformLayout();
            this.gpsTabControl.ResumeLayout(false);
            this.gpsMapTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox consoleGroup;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.TextBox consoleInput;
        private System.Windows.Forms.Button consoleClearButton;
        private System.Windows.Forms.Button sendConsoleInputButton;
        private System.Windows.Forms.GroupBox gpsDataGroup;
        private System.Windows.Forms.MenuStrip topMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingsMenu;
        private System.Windows.Forms.ToolStripMenuItem presetMenu;
        private System.Windows.Forms.ToolStripMenuItem presetXbee;
        private System.Windows.Forms.ToolStripMenuItem presetRaspberryPi;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox currentPortGroup;
        private System.Windows.Forms.GroupBox statusGroup;
        private System.Windows.Forms.Button portSwitchButton;
        private System.Windows.Forms.TextBox portStatusText;
        private System.Windows.Forms.TextBox currentPortText;
        private System.Windows.Forms.Button portScanButton;
        private System.Windows.Forms.GroupBox gpsValidityGroup;
        private System.Windows.Forms.TextBox gpsValidityText;
        private System.Windows.Forms.ToolTip rocketpiToolTip;
        private System.Windows.Forms.GroupBox gpsTimeStampGroup;
        private System.Windows.Forms.TextBox gpsTimeStampText;
        private System.Windows.Forms.GroupBox gpsLatGroup;
        private System.Windows.Forms.TextBox gpsLatText;
        private System.Windows.Forms.TextBox gpsLongText;
        private System.Windows.Forms.GroupBox gpsLongGroup;
        private System.Windows.Forms.TabControl gpsTabControl;
        private System.Windows.Forms.TabPage gpsMapTabPage;
        private System.Windows.Forms.TabPage gpsDataTabPage;
        private GMap.NET.WindowsForms.GMapControl gpsMap;
        private System.Windows.Forms.ToolStripMenuItem portMenu;
        private System.Windows.Forms.ToolStripMenuItem portCom1;
        private System.Windows.Forms.ToolStripMenuItem portCom2;
        private System.Windows.Forms.ToolStripMenuItem portCom3;
        private System.Windows.Forms.ToolStripMenuItem portCom4;
        private System.Windows.Forms.ToolStripMenuItem portCom5;
        private System.Windows.Forms.ToolStripMenuItem portCom6;
        private System.Windows.Forms.ToolStripMenuItem portCom7;
        private System.Windows.Forms.ToolStripMenuItem portCom8;
        private System.Windows.Forms.RichTextBox consoleText;
    }
}