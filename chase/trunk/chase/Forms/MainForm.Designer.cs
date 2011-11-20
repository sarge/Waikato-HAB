﻿namespace Demo.WindowsForms
{
   partial class MainForm
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
         if(disposing && (components != null))
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
          this.label7 = new System.Windows.Forms.Label();
          this.comboBoxMapType = new System.Windows.Forms.ComboBox();
          this.groupBox3 = new System.Windows.Forms.GroupBox();
          this.label6 = new System.Windows.Forms.Label();
          this.textBoxGeo = new System.Windows.Forms.TextBox();
          this.button1 = new System.Windows.Forms.Button();
          this.button8 = new System.Windows.Forms.Button();
          this.label2 = new System.Windows.Forms.Label();
          this.label1 = new System.Windows.Forms.Label();
          this.textBoxLng = new System.Windows.Forms.TextBox();
          this.textBoxLat = new System.Windows.Forms.TextBox();
          this.button5 = new System.Windows.Forms.Button();
          this.button4 = new System.Windows.Forms.Button();
          this.trackBar1 = new System.Windows.Forms.TrackBar();
          this.groupBox5 = new System.Windows.Forms.GroupBox();
          this.button16 = new System.Windows.Forms.Button();
          this.button13 = new System.Windows.Forms.Button();
          this.checkBoxDebug = new System.Windows.Forms.CheckBox();
          this.button12 = new System.Windows.Forms.Button();
          this.label8 = new System.Windows.Forms.Label();
          this.comboBoxMode = new System.Windows.Forms.ComboBox();
          this.checkBoxCanDrag = new System.Windows.Forms.CheckBox();
          this.checkBoxCurrentMarker = new System.Windows.Forms.CheckBox();
          this.button11 = new System.Windows.Forms.Button();
          this.button10 = new System.Windows.Forms.Button();
          this.button9 = new System.Windows.Forms.Button();
          this.checkBoxUseGeoCache = new System.Windows.Forms.CheckBox();
          this.checkBoxUseRouteCache = new System.Windows.Forms.CheckBox();
          this.button3 = new System.Windows.Forms.Button();
          this.groupBox7 = new System.Windows.Forms.GroupBox();
          this.buttonExportToGpx = new System.Windows.Forms.Button();
          this.MobileLogTo = new System.Windows.Forms.DateTimePicker();
          this.label3 = new System.Windows.Forms.Label();
          this.button15 = new System.Windows.Forms.Button();
          this.MobileLogFrom = new System.Windows.Forms.DateTimePicker();
          this.button14 = new System.Windows.Forms.Button();
          this.buttonSetEnd = new System.Windows.Forms.Button();
          this.buttonSetStart = new System.Windows.Forms.Button();
          this.button6 = new System.Windows.Forms.Button();
          this.groupBox8 = new System.Windows.Forms.GroupBox();
          this.button7 = new System.Windows.Forms.Button();
          this.checkBoxPlacemarkInfo = new System.Windows.Forms.CheckBox();
          this.panelMenu = new BSE.Windows.Forms.Panel();
          this.splitter1 = new BSE.Windows.Forms.Splitter();
          this.xPanderPanelList1 = new BSE.Windows.Forms.XPanderPanelList();
          this.xPanderPanelMain = new BSE.Windows.Forms.XPanderPanel();
          this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
          this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
          this.xPanderPanelCache = new BSE.Windows.Forms.XPanderPanel();
          this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
          this.textBoxMemory = new System.Windows.Forms.TextBox();
          this.label10 = new System.Windows.Forms.Label();
          this.button2 = new System.Windows.Forms.Button();
          this.xPanderPanelInfo = new BSE.Windows.Forms.XPanderPanel();
          this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
          this.textBoxZoomCurrent = new System.Windows.Forms.TextBox();
          this.textBoxrouteCount = new System.Windows.Forms.TextBox();
          this.label12 = new System.Windows.Forms.Label();
          this.label9 = new System.Windows.Forms.Label();
          this.textBoxLngCurrent = new System.Windows.Forms.TextBox();
          this.textBoxMarkerCount = new System.Windows.Forms.TextBox();
          this.label11 = new System.Windows.Forms.Label();
          this.label4 = new System.Windows.Forms.Label();
          this.textBoxLatCurrent = new System.Windows.Forms.TextBox();
          this.label5 = new System.Windows.Forms.Label();
          this.xPanderPanelLive = new BSE.Windows.Forms.XPanderPanel();
          this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
          this.buttonLoadKML = new System.Windows.Forms.Button();
          this.buttonConnectGPS = new System.Windows.Forms.Button();
          this.comboBoxCOMPorts = new System.Windows.Forms.ComboBox();
          this.textBoxGPSData = new System.Windows.Forms.TextBox();
          this.panel2 = new System.Windows.Forms.Panel();
          this.MainMap = new Demo.WindowsForms.Map();
          this.panel4 = new System.Windows.Forms.Panel();
          this.comboBoxGPSType = new System.Windows.Forms.ComboBox();
          this.groupBox3.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
          this.groupBox5.SuspendLayout();
          this.groupBox7.SuspendLayout();
          this.groupBox8.SuspendLayout();
          this.panelMenu.SuspendLayout();
          this.xPanderPanelList1.SuspendLayout();
          this.xPanderPanelMain.SuspendLayout();
          this.tableLayoutPanel4.SuspendLayout();
          this.tableLayoutPanel5.SuspendLayout();
          this.xPanderPanelCache.SuspendLayout();
          this.tableLayoutPanel1.SuspendLayout();
          this.xPanderPanelInfo.SuspendLayout();
          this.tableLayoutPanel2.SuspendLayout();
          this.xPanderPanelLive.SuspendLayout();
          this.tableLayoutPanel3.SuspendLayout();
          this.panel2.SuspendLayout();
          this.panel4.SuspendLayout();
          this.SuspendLayout();
          // 
          // label7
          // 
          this.label7.AutoSize = true;
          this.label7.Location = new System.Drawing.Point(132, 22);
          this.label7.Name = "label7";
          this.label7.Size = new System.Drawing.Size(27, 13);
          this.label7.TabIndex = 31;
          this.label7.Text = "type";
          // 
          // comboBoxMapType
          // 
          this.comboBoxMapType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
          this.comboBoxMapType.FormattingEnabled = true;
          this.comboBoxMapType.Location = new System.Drawing.Point(8, 19);
          this.comboBoxMapType.Name = "comboBoxMapType";
          this.comboBoxMapType.Size = new System.Drawing.Size(123, 21);
          this.comboBoxMapType.TabIndex = 9;
          this.comboBoxMapType.DropDownClosed += new System.EventHandler(this.comboBoxMapType_DropDownClosed);
          // 
          // groupBox3
          // 
          this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
          this.groupBox3.Controls.Add(this.label6);
          this.groupBox3.Controls.Add(this.textBoxGeo);
          this.groupBox3.Controls.Add(this.button1);
          this.groupBox3.Controls.Add(this.button8);
          this.groupBox3.Controls.Add(this.label2);
          this.groupBox3.Controls.Add(this.label1);
          this.groupBox3.Controls.Add(this.textBoxLng);
          this.groupBox3.Controls.Add(this.textBoxLat);
          this.groupBox3.Location = new System.Drawing.Point(3, 3);
          this.groupBox3.Name = "groupBox3";
          this.groupBox3.Size = new System.Drawing.Size(165, 128);
          this.groupBox3.TabIndex = 28;
          this.groupBox3.TabStop = false;
          this.groupBox3.Text = "coordinates";
          // 
          // label6
          // 
          this.label6.AutoSize = true;
          this.label6.Location = new System.Drawing.Point(132, 74);
          this.label6.Name = "label6";
          this.label6.Size = new System.Drawing.Size(28, 13);
          this.label6.TabIndex = 11;
          this.label6.Text = "goto";
          // 
          // textBoxGeo
          // 
          this.textBoxGeo.Location = new System.Drawing.Point(9, 71);
          this.textBoxGeo.Name = "textBoxGeo";
          this.textBoxGeo.Size = new System.Drawing.Size(122, 20);
          this.textBoxGeo.TabIndex = 10;
          this.textBoxGeo.Text = "lietuva vilnius";
          this.textBoxGeo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGeo_KeyPress);
          // 
          // button1
          // 
          this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
          this.button1.Location = new System.Drawing.Point(85, 98);
          this.button1.Name = "button1";
          this.button1.Size = new System.Drawing.Size(74, 24);
          this.button1.TabIndex = 9;
          this.button1.Text = "Reload";
          this.button1.UseVisualStyleBackColor = true;
          this.button1.Click += new System.EventHandler(this.button1_Click);
          // 
          // button8
          // 
          this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
          this.button8.Location = new System.Drawing.Point(9, 98);
          this.button8.Name = "button8";
          this.button8.Size = new System.Drawing.Size(72, 24);
          this.button8.TabIndex = 8;
          this.button8.Text = "GoTo !";
          this.button8.UseVisualStyleBackColor = true;
          this.button8.Click += new System.EventHandler(this.button8_Click);
          // 
          // label2
          // 
          this.label2.AutoSize = true;
          this.label2.Location = new System.Drawing.Point(132, 48);
          this.label2.Name = "label2";
          this.label2.Size = new System.Drawing.Size(21, 13);
          this.label2.TabIndex = 3;
          this.label2.Text = "lng";
          // 
          // label1
          // 
          this.label1.AutoSize = true;
          this.label1.Location = new System.Drawing.Point(132, 22);
          this.label1.Name = "label1";
          this.label1.Size = new System.Drawing.Size(18, 13);
          this.label1.TabIndex = 2;
          this.label1.Text = "lat";
          // 
          // textBoxLng
          // 
          this.textBoxLng.Location = new System.Drawing.Point(9, 45);
          this.textBoxLng.Name = "textBoxLng";
          this.textBoxLng.Size = new System.Drawing.Size(122, 20);
          this.textBoxLng.TabIndex = 1;
          this.textBoxLng.Text = "175.2597";
          // 
          // textBoxLat
          // 
          this.textBoxLat.Location = new System.Drawing.Point(9, 19);
          this.textBoxLat.Name = "textBoxLat";
          this.textBoxLat.Size = new System.Drawing.Size(122, 20);
          this.textBoxLat.TabIndex = 0;
          this.textBoxLat.Text = "-37.7881";
          // 
          // button5
          // 
          this.button5.Location = new System.Drawing.Point(94, 45);
          this.button5.Name = "button5";
          this.button5.Size = new System.Drawing.Size(63, 24);
          this.button5.TabIndex = 13;
          this.button5.Text = "Clear All";
          this.button5.UseVisualStyleBackColor = true;
          this.button5.Click += new System.EventHandler(this.button5_Click);
          // 
          // button4
          // 
          this.button4.Location = new System.Drawing.Point(6, 15);
          this.button4.Name = "button4";
          this.button4.Size = new System.Drawing.Size(82, 24);
          this.button4.TabIndex = 12;
          this.button4.Text = "Add Marker";
          this.button4.UseVisualStyleBackColor = true;
          this.button4.Click += new System.EventHandler(this.button4_Click);
          // 
          // trackBar1
          // 
          this.trackBar1.BackColor = System.Drawing.Color.AliceBlue;
          this.trackBar1.Dock = System.Windows.Forms.DockStyle.Left;
          this.trackBar1.LargeChange = 1;
          this.trackBar1.Location = new System.Drawing.Point(3, 3);
          this.trackBar1.Maximum = 17;
          this.trackBar1.Minimum = 1;
          this.trackBar1.Name = "trackBar1";
          this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
          this.trackBar1.Size = new System.Drawing.Size(45, 1);
          this.trackBar1.TabIndex = 29;
          this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
          this.trackBar1.Value = 12;
          this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
          // 
          // groupBox5
          // 
          this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
          this.groupBox5.Controls.Add(this.button16);
          this.groupBox5.Controls.Add(this.button13);
          this.groupBox5.Controls.Add(this.checkBoxDebug);
          this.groupBox5.Controls.Add(this.button12);
          this.groupBox5.Controls.Add(this.label8);
          this.groupBox5.Controls.Add(this.comboBoxMode);
          this.groupBox5.Controls.Add(this.checkBoxCanDrag);
          this.groupBox5.Controls.Add(this.checkBoxCurrentMarker);
          this.groupBox5.Controls.Add(this.label7);
          this.groupBox5.Controls.Add(this.comboBoxMapType);
          this.groupBox5.Location = new System.Drawing.Point(3, 137);
          this.groupBox5.Name = "groupBox5";
          this.groupBox5.Size = new System.Drawing.Size(165, 146);
          this.groupBox5.TabIndex = 31;
          this.groupBox5.TabStop = false;
          this.groupBox5.Text = "gmap";
          // 
          // button16
          // 
          this.button16.Location = new System.Drawing.Point(92, 92);
          this.button16.Name = "button16";
          this.button16.Size = new System.Drawing.Size(69, 24);
          this.button16.TabIndex = 49;
          this.button16.Text = "GPX...";
          this.button16.UseVisualStyleBackColor = true;
          this.button16.Click += new System.EventHandler(this.button16_Click);
          // 
          // button13
          // 
          this.button13.Location = new System.Drawing.Point(9, 117);
          this.button13.Margin = new System.Windows.Forms.Padding(2);
          this.button13.Name = "button13";
          this.button13.Size = new System.Drawing.Size(73, 24);
          this.button13.TabIndex = 41;
          this.button13.Text = "Get Static";
          this.button13.UseVisualStyleBackColor = true;
          this.button13.Click += new System.EventHandler(this.button13_Click);
          // 
          // checkBoxDebug
          // 
          this.checkBoxDebug.AutoSize = true;
          this.checkBoxDebug.Location = new System.Drawing.Point(104, 74);
          this.checkBoxDebug.Margin = new System.Windows.Forms.Padding(2);
          this.checkBoxDebug.Name = "checkBoxDebug";
          this.checkBoxDebug.Size = new System.Drawing.Size(45, 17);
          this.checkBoxDebug.TabIndex = 40;
          this.checkBoxDebug.Text = "Grid";
          this.checkBoxDebug.UseVisualStyleBackColor = true;
          this.checkBoxDebug.CheckedChanged += new System.EventHandler(this.checkBoxDebug_CheckedChanged);
          // 
          // button12
          // 
          this.button12.Location = new System.Drawing.Point(92, 117);
          this.button12.Margin = new System.Windows.Forms.Padding(2);
          this.button12.Name = "button12";
          this.button12.Size = new System.Drawing.Size(69, 24);
          this.button12.TabIndex = 39;
          this.button12.Text = "Save View";
          this.button12.UseVisualStyleBackColor = true;
          this.button12.Click += new System.EventHandler(this.button12_Click);
          // 
          // label8
          // 
          this.label8.AutoSize = true;
          this.label8.Location = new System.Drawing.Point(132, 49);
          this.label8.Name = "label8";
          this.label8.Size = new System.Drawing.Size(33, 13);
          this.label8.TabIndex = 38;
          this.label8.Text = "mode";
          // 
          // comboBoxMode
          // 
          this.comboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
          this.comboBoxMode.FormattingEnabled = true;
          this.comboBoxMode.Location = new System.Drawing.Point(8, 46);
          this.comboBoxMode.Name = "comboBoxMode";
          this.comboBoxMode.Size = new System.Drawing.Size(123, 21);
          this.comboBoxMode.TabIndex = 37;
          this.comboBoxMode.DropDownClosed += new System.EventHandler(this.comboBoxMode_DropDownClosed);
          // 
          // checkBoxCanDrag
          // 
          this.checkBoxCanDrag.AutoSize = true;
          this.checkBoxCanDrag.Checked = true;
          this.checkBoxCanDrag.CheckState = System.Windows.Forms.CheckState.Checked;
          this.checkBoxCanDrag.Location = new System.Drawing.Point(9, 95);
          this.checkBoxCanDrag.Name = "checkBoxCanDrag";
          this.checkBoxCanDrag.Size = new System.Drawing.Size(73, 17);
          this.checkBoxCanDrag.TabIndex = 36;
          this.checkBoxCanDrag.Text = "Drag Map";
          this.checkBoxCanDrag.UseVisualStyleBackColor = true;
          this.checkBoxCanDrag.CheckedChanged += new System.EventHandler(this.checkBoxCanDrag_CheckedChanged);
          // 
          // checkBoxCurrentMarker
          // 
          this.checkBoxCurrentMarker.AutoSize = true;
          this.checkBoxCurrentMarker.Checked = true;
          this.checkBoxCurrentMarker.CheckState = System.Windows.Forms.CheckState.Checked;
          this.checkBoxCurrentMarker.Location = new System.Drawing.Point(9, 73);
          this.checkBoxCurrentMarker.Name = "checkBoxCurrentMarker";
          this.checkBoxCurrentMarker.Size = new System.Drawing.Size(96, 17);
          this.checkBoxCurrentMarker.TabIndex = 35;
          this.checkBoxCurrentMarker.Text = "Current Marker";
          this.checkBoxCurrentMarker.UseVisualStyleBackColor = true;
          this.checkBoxCurrentMarker.CheckedChanged += new System.EventHandler(this.checkBoxCurrentMarker_CheckedChanged);
          // 
          // button11
          // 
          this.button11.Dock = System.Windows.Forms.DockStyle.Top;
          this.button11.Location = new System.Drawing.Point(18, 71);
          this.button11.Name = "button11";
          this.button11.Size = new System.Drawing.Size(190, 20);
          this.button11.TabIndex = 38;
          this.button11.Text = "Prefetch";
          this.button11.UseVisualStyleBackColor = true;
          this.button11.Click += new System.EventHandler(this.button11_Click);
          // 
          // button10
          // 
          this.button10.Dock = System.Windows.Forms.DockStyle.Top;
          this.button10.Location = new System.Drawing.Point(18, 19);
          this.button10.Name = "button10";
          this.button10.Size = new System.Drawing.Size(190, 20);
          this.button10.TabIndex = 5;
          this.button10.Text = "Import";
          this.button10.UseVisualStyleBackColor = true;
          this.button10.Click += new System.EventHandler(this.button10_Click);
          // 
          // button9
          // 
          this.button9.Dock = System.Windows.Forms.DockStyle.Top;
          this.button9.Location = new System.Drawing.Point(18, 45);
          this.button9.Name = "button9";
          this.button9.Size = new System.Drawing.Size(190, 20);
          this.button9.TabIndex = 4;
          this.button9.Text = "Export";
          this.button9.UseVisualStyleBackColor = true;
          this.button9.Click += new System.EventHandler(this.button9_Click);
          // 
          // checkBoxUseGeoCache
          // 
          this.checkBoxUseGeoCache.AutoSize = true;
          this.checkBoxUseGeoCache.Checked = true;
          this.checkBoxUseGeoCache.CheckState = System.Windows.Forms.CheckState.Checked;
          this.checkBoxUseGeoCache.Location = new System.Drawing.Point(18, 226);
          this.checkBoxUseGeoCache.Name = "checkBoxUseGeoCache";
          this.checkBoxUseGeoCache.Size = new System.Drawing.Size(76, 17);
          this.checkBoxUseGeoCache.TabIndex = 3;
          this.checkBoxUseGeoCache.Text = "geocoding";
          this.checkBoxUseGeoCache.UseVisualStyleBackColor = true;
          this.checkBoxUseGeoCache.CheckedChanged += new System.EventHandler(this.checkBoxUseCache_CheckedChanged);
          // 
          // checkBoxUseRouteCache
          // 
          this.checkBoxUseRouteCache.AutoSize = true;
          this.checkBoxUseRouteCache.Checked = true;
          this.checkBoxUseRouteCache.CheckState = System.Windows.Forms.CheckState.Checked;
          this.checkBoxUseRouteCache.Location = new System.Drawing.Point(18, 203);
          this.checkBoxUseRouteCache.Name = "checkBoxUseRouteCache";
          this.checkBoxUseRouteCache.Size = new System.Drawing.Size(58, 17);
          this.checkBoxUseRouteCache.TabIndex = 2;
          this.checkBoxUseRouteCache.Text = "routing";
          this.checkBoxUseRouteCache.UseVisualStyleBackColor = true;
          this.checkBoxUseRouteCache.CheckedChanged += new System.EventHandler(this.checkBoxUseCache_CheckedChanged);
          // 
          // button3
          // 
          this.button3.Location = new System.Drawing.Point(9, 49);
          this.button3.Name = "button3";
          this.button3.Size = new System.Drawing.Size(73, 24);
          this.button3.TabIndex = 33;
          this.button3.Text = "Add Route";
          this.button3.UseVisualStyleBackColor = true;
          this.button3.Click += new System.EventHandler(this.button3_Click);
          // 
          // groupBox7
          // 
          this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
          this.groupBox7.Controls.Add(this.buttonExportToGpx);
          this.groupBox7.Controls.Add(this.MobileLogTo);
          this.groupBox7.Controls.Add(this.label3);
          this.groupBox7.Controls.Add(this.button15);
          this.groupBox7.Controls.Add(this.MobileLogFrom);
          this.groupBox7.Controls.Add(this.button14);
          this.groupBox7.Controls.Add(this.buttonSetEnd);
          this.groupBox7.Controls.Add(this.buttonSetStart);
          this.groupBox7.Controls.Add(this.button6);
          this.groupBox7.Controls.Add(this.button3);
          this.groupBox7.Location = new System.Drawing.Point(3, 289);
          this.groupBox7.Name = "groupBox7";
          this.groupBox7.Size = new System.Drawing.Size(165, 155);
          this.groupBox7.TabIndex = 35;
          this.groupBox7.TabStop = false;
          this.groupBox7.Text = "routing";
          // 
          // buttonExportToGpx
          // 
          this.buttonExportToGpx.Location = new System.Drawing.Point(124, 78);
          this.buttonExportToGpx.Margin = new System.Windows.Forms.Padding(2);
          this.buttonExportToGpx.Name = "buttonExportToGpx";
          this.buttonExportToGpx.Size = new System.Drawing.Size(37, 37);
          this.buttonExportToGpx.TabIndex = 48;
          this.buttonExportToGpx.Text = "to GPX";
          this.buttonExportToGpx.UseVisualStyleBackColor = true;
          this.buttonExportToGpx.Click += new System.EventHandler(this.buttonExportToGpx_Click);
          // 
          // MobileLogTo
          // 
          this.MobileLogTo.CustomFormat = "yyyy\'.\'MM\'.\'dd HH\':\'mm";
          this.MobileLogTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
          this.MobileLogTo.Location = new System.Drawing.Point(9, 99);
          this.MobileLogTo.Margin = new System.Windows.Forms.Padding(2);
          this.MobileLogTo.Name = "MobileLogTo";
          this.MobileLogTo.ShowCheckBox = true;
          this.MobileLogTo.Size = new System.Drawing.Size(110, 20);
          this.MobileLogTo.TabIndex = 47;
          // 
          // label3
          // 
          this.label3.AutoSize = true;
          this.label3.Location = new System.Drawing.Point(9, 128);
          this.label3.Name = "label3";
          this.label3.Size = new System.Drawing.Size(34, 13);
          this.label3.TabIndex = 46;
          this.label3.Text = "Clear:";
          // 
          // button15
          // 
          this.button15.Location = new System.Drawing.Point(104, 124);
          this.button15.Name = "button15";
          this.button15.Size = new System.Drawing.Size(56, 24);
          this.button15.TabIndex = 45;
          this.button15.Text = "Polygons";
          this.button15.UseVisualStyleBackColor = true;
          this.button15.Click += new System.EventHandler(this.button15_Click);
          // 
          // MobileLogFrom
          // 
          this.MobileLogFrom.CustomFormat = "yyyy\'.\'MM\'.\'dd HH\':\'mm";
          this.MobileLogFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
          this.MobileLogFrom.Location = new System.Drawing.Point(9, 78);
          this.MobileLogFrom.Margin = new System.Windows.Forms.Padding(2);
          this.MobileLogFrom.Name = "MobileLogFrom";
          this.MobileLogFrom.ShowCheckBox = true;
          this.MobileLogFrom.Size = new System.Drawing.Size(110, 20);
          this.MobileLogFrom.TabIndex = 44;
          this.MobileLogFrom.Value = new System.DateTime(2010, 5, 10, 15, 41, 0, 0);
          // 
          // button14
          // 
          this.button14.Location = new System.Drawing.Point(88, 49);
          this.button14.Name = "button14";
          this.button14.Size = new System.Drawing.Size(73, 24);
          this.button14.TabIndex = 43;
          this.button14.Text = "Mobile log...";
          this.button14.UseVisualStyleBackColor = true;
          this.button14.Click += new System.EventHandler(this.button14_Click);
          // 
          // buttonSetEnd
          // 
          this.buttonSetEnd.Location = new System.Drawing.Point(88, 19);
          this.buttonSetEnd.Name = "buttonSetEnd";
          this.buttonSetEnd.Size = new System.Drawing.Size(73, 24);
          this.buttonSetEnd.TabIndex = 42;
          this.buttonSetEnd.Text = "set End";
          this.buttonSetEnd.UseVisualStyleBackColor = true;
          this.buttonSetEnd.Click += new System.EventHandler(this.buttonSetEnd_Click);
          // 
          // buttonSetStart
          // 
          this.buttonSetStart.Location = new System.Drawing.Point(9, 19);
          this.buttonSetStart.Name = "buttonSetStart";
          this.buttonSetStart.Size = new System.Drawing.Size(73, 24);
          this.buttonSetStart.TabIndex = 41;
          this.buttonSetStart.Text = "set Start";
          this.buttonSetStart.UseVisualStyleBackColor = true;
          this.buttonSetStart.Click += new System.EventHandler(this.buttonSetStart_Click);
          // 
          // button6
          // 
          this.button6.Location = new System.Drawing.Point(45, 124);
          this.button6.Name = "button6";
          this.button6.Size = new System.Drawing.Size(55, 24);
          this.button6.TabIndex = 34;
          this.button6.Text = "Routes";
          this.button6.UseVisualStyleBackColor = true;
          this.button6.Click += new System.EventHandler(this.button6_Click);
          // 
          // groupBox8
          // 
          this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
          this.groupBox8.Controls.Add(this.button7);
          this.groupBox8.Controls.Add(this.checkBoxPlacemarkInfo);
          this.groupBox8.Controls.Add(this.button5);
          this.groupBox8.Controls.Add(this.button4);
          this.groupBox8.Location = new System.Drawing.Point(3, 450);
          this.groupBox8.Name = "groupBox8";
          this.groupBox8.Size = new System.Drawing.Size(165, 114);
          this.groupBox8.TabIndex = 37;
          this.groupBox8.TabStop = false;
          this.groupBox8.Text = "markers";
          // 
          // button7
          // 
          this.button7.Location = new System.Drawing.Point(6, 45);
          this.button7.Name = "button7";
          this.button7.Size = new System.Drawing.Size(82, 24);
          this.button7.TabIndex = 15;
          this.button7.Text = "Zoom Center";
          this.button7.UseVisualStyleBackColor = true;
          this.button7.Click += new System.EventHandler(this.button7_Click);
          // 
          // checkBoxPlacemarkInfo
          // 
          this.checkBoxPlacemarkInfo.AutoSize = true;
          this.checkBoxPlacemarkInfo.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
          this.checkBoxPlacemarkInfo.Checked = true;
          this.checkBoxPlacemarkInfo.CheckState = System.Windows.Forms.CheckState.Checked;
          this.checkBoxPlacemarkInfo.Location = new System.Drawing.Point(94, 19);
          this.checkBoxPlacemarkInfo.Name = "checkBoxPlacemarkInfo";
          this.checkBoxPlacemarkInfo.Size = new System.Drawing.Size(72, 17);
          this.checkBoxPlacemarkInfo.TabIndex = 14;
          this.checkBoxPlacemarkInfo.Text = "place info";
          this.checkBoxPlacemarkInfo.UseVisualStyleBackColor = true;
          // 
          // panelMenu
          // 
          this.panelMenu.AssociatedSplitter = this.splitter1;
          this.panelMenu.BackColor = System.Drawing.Color.Transparent;
          this.panelMenu.CaptionFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.panelMenu.CaptionHeight = 27;
          this.panelMenu.Controls.Add(this.xPanderPanelList1);
          this.panelMenu.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
          this.panelMenu.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
          this.panelMenu.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
          this.panelMenu.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
          this.panelMenu.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
          this.panelMenu.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
          this.panelMenu.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
          this.panelMenu.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
          this.panelMenu.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
          this.panelMenu.CustomColors.CollapsedCaptionText = System.Drawing.SystemColors.ControlText;
          this.panelMenu.CustomColors.ContentGradientBegin = System.Drawing.SystemColors.ButtonFace;
          this.panelMenu.CustomColors.ContentGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
          this.panelMenu.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
          this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
          this.panelMenu.ForeColor = System.Drawing.SystemColors.ControlText;
          this.panelMenu.Image = null;
          this.panelMenu.LinearGradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
          this.panelMenu.Location = new System.Drawing.Point(662, 0);
          this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
          this.panelMenu.MinimumSize = new System.Drawing.Size(27, 27);
          this.panelMenu.Name = "panelMenu";
          this.panelMenu.PanelStyle = BSE.Windows.Forms.PanelStyle.Office2007;
          this.panelMenu.ShowExpandIcon = true;
          this.panelMenu.Size = new System.Drawing.Size(228, 732);
          this.panelMenu.TabIndex = 40;
          this.panelMenu.Text = "Menu";
          this.panelMenu.ToolTipTextCloseIcon = null;
          this.panelMenu.ToolTipTextExpandIconPanelCollapsed = "maximize";
          this.panelMenu.ToolTipTextExpandIconPanelExpanded = "minimize";
          // 
          // splitter1
          // 
          this.splitter1.BackColor = System.Drawing.Color.Transparent;
          this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
          this.splitter1.Enabled = false;
          this.splitter1.Location = new System.Drawing.Point(660, 0);
          this.splitter1.Margin = new System.Windows.Forms.Padding(2);
          this.splitter1.MinExtra = 390;
          this.splitter1.MinSize = 390;
          this.splitter1.Name = "splitter1";
          this.splitter1.Size = new System.Drawing.Size(2, 732);
          this.splitter1.TabIndex = 42;
          this.splitter1.TabStop = false;
          // 
          // xPanderPanelList1
          // 
          this.xPanderPanelList1.CaptionStyle = BSE.Windows.Forms.CaptionStyle.Flat;
          this.xPanderPanelList1.Controls.Add(this.xPanderPanelMain);
          this.xPanderPanelList1.Controls.Add(this.xPanderPanelCache);
          this.xPanderPanelList1.Controls.Add(this.xPanderPanelInfo);
          this.xPanderPanelList1.Controls.Add(this.xPanderPanelLive);
          this.xPanderPanelList1.Dock = System.Windows.Forms.DockStyle.Fill;
          this.xPanderPanelList1.GradientBackground = System.Drawing.Color.Empty;
          this.xPanderPanelList1.Location = new System.Drawing.Point(0, 28);
          this.xPanderPanelList1.Margin = new System.Windows.Forms.Padding(2);
          this.xPanderPanelList1.Name = "xPanderPanelList1";
          this.xPanderPanelList1.PanelColors = null;
          this.xPanderPanelList1.PanelStyle = BSE.Windows.Forms.PanelStyle.Office2007;
          this.xPanderPanelList1.ShowExpandIcon = true;
          this.xPanderPanelList1.Size = new System.Drawing.Size(228, 703);
          this.xPanderPanelList1.TabIndex = 0;
          this.xPanderPanelList1.Text = "xPanderPanelList1";
          // 
          // xPanderPanelMain
          // 
          this.xPanderPanelMain.CaptionFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
          this.xPanderPanelMain.Controls.Add(this.tableLayoutPanel4);
          this.xPanderPanelMain.CustomColors.BackColor = System.Drawing.SystemColors.Control;
          this.xPanderPanelMain.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
          this.xPanderPanelMain.CustomColors.CaptionCheckedGradientBegin = System.Drawing.Color.Empty;
          this.xPanderPanelMain.CustomColors.CaptionCheckedGradientEnd = System.Drawing.Color.Empty;
          this.xPanderPanelMain.CustomColors.CaptionCheckedGradientMiddle = System.Drawing.Color.Empty;
          this.xPanderPanelMain.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
          this.xPanderPanelMain.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
          this.xPanderPanelMain.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
          this.xPanderPanelMain.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
          this.xPanderPanelMain.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
          this.xPanderPanelMain.CustomColors.CaptionPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
          this.xPanderPanelMain.CustomColors.CaptionPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
          this.xPanderPanelMain.CustomColors.CaptionPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
          this.xPanderPanelMain.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
          this.xPanderPanelMain.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
          this.xPanderPanelMain.CustomColors.CaptionSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
          this.xPanderPanelMain.CustomColors.CaptionSelectedText = System.Drawing.SystemColors.ControlText;
          this.xPanderPanelMain.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
          this.xPanderPanelMain.CustomColors.FlatCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
          this.xPanderPanelMain.CustomColors.FlatCaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
          this.xPanderPanelMain.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
          this.xPanderPanelMain.ForeColor = System.Drawing.SystemColors.ControlText;
          this.xPanderPanelMain.Image = null;
          this.xPanderPanelMain.IsClosable = false;
          this.xPanderPanelMain.Margin = new System.Windows.Forms.Padding(2);
          this.xPanderPanelMain.Name = "xPanderPanelMain";
          this.xPanderPanelMain.PanelStyle = BSE.Windows.Forms.PanelStyle.Office2007;
          this.xPanderPanelMain.Size = new System.Drawing.Size(228, 25);
          this.xPanderPanelMain.TabIndex = 0;
          this.xPanderPanelMain.Text = "map";
          this.xPanderPanelMain.ToolTipTextCloseIcon = null;
          this.xPanderPanelMain.ToolTipTextExpandIconPanelCollapsed = null;
          this.xPanderPanelMain.ToolTipTextExpandIconPanelExpanded = null;
          this.xPanderPanelMain.Click += new System.EventHandler(this.xPanderPanel1_Click);
          // 
          // tableLayoutPanel4
          // 
          this.tableLayoutPanel4.ColumnCount = 2;
          this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
          this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.27536F));
          this.tableLayoutPanel4.Controls.Add(this.trackBar1, 0, 0);
          this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
          this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
          this.tableLayoutPanel4.Location = new System.Drawing.Point(1, 25);
          this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
          this.tableLayoutPanel4.Name = "tableLayoutPanel4";
          this.tableLayoutPanel4.RowCount = 1;
          this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
          this.tableLayoutPanel4.Size = new System.Drawing.Size(226, 0);
          this.tableLayoutPanel4.TabIndex = 38;
          // 
          // tableLayoutPanel5
          // 
          this.tableLayoutPanel5.ColumnCount = 1;
          this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
          this.tableLayoutPanel5.Controls.Add(this.groupBox3, 0, 0);
          this.tableLayoutPanel5.Controls.Add(this.groupBox8, 0, 3);
          this.tableLayoutPanel5.Controls.Add(this.groupBox7, 0, 2);
          this.tableLayoutPanel5.Controls.Add(this.groupBox5, 0, 1);
          this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
          this.tableLayoutPanel5.Location = new System.Drawing.Point(53, 2);
          this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
          this.tableLayoutPanel5.Name = "tableLayoutPanel5";
          this.tableLayoutPanel5.RowCount = 5;
          this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
          this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
          this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
          this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
          this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
          this.tableLayoutPanel5.Size = new System.Drawing.Size(171, 1);
          this.tableLayoutPanel5.TabIndex = 30;
          // 
          // xPanderPanelCache
          // 
          this.xPanderPanelCache.CaptionFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
          this.xPanderPanelCache.Controls.Add(this.tableLayoutPanel1);
          this.xPanderPanelCache.CustomColors.BackColor = System.Drawing.SystemColors.Control;
          this.xPanderPanelCache.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
          this.xPanderPanelCache.CustomColors.CaptionCheckedGradientBegin = System.Drawing.Color.Empty;
          this.xPanderPanelCache.CustomColors.CaptionCheckedGradientEnd = System.Drawing.Color.Empty;
          this.xPanderPanelCache.CustomColors.CaptionCheckedGradientMiddle = System.Drawing.Color.Empty;
          this.xPanderPanelCache.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
          this.xPanderPanelCache.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
          this.xPanderPanelCache.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
          this.xPanderPanelCache.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
          this.xPanderPanelCache.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
          this.xPanderPanelCache.CustomColors.CaptionPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
          this.xPanderPanelCache.CustomColors.CaptionPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
          this.xPanderPanelCache.CustomColors.CaptionPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
          this.xPanderPanelCache.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
          this.xPanderPanelCache.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
          this.xPanderPanelCache.CustomColors.CaptionSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
          this.xPanderPanelCache.CustomColors.CaptionSelectedText = System.Drawing.SystemColors.ControlText;
          this.xPanderPanelCache.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
          this.xPanderPanelCache.CustomColors.FlatCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
          this.xPanderPanelCache.CustomColors.FlatCaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
          this.xPanderPanelCache.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
          this.xPanderPanelCache.ForeColor = System.Drawing.SystemColors.ControlText;
          this.xPanderPanelCache.Image = null;
          this.xPanderPanelCache.IsClosable = false;
          this.xPanderPanelCache.Margin = new System.Windows.Forms.Padding(2);
          this.xPanderPanelCache.Name = "xPanderPanelCache";
          this.xPanderPanelCache.PanelStyle = BSE.Windows.Forms.PanelStyle.Office2007;
          this.xPanderPanelCache.Size = new System.Drawing.Size(228, 25);
          this.xPanderPanelCache.TabIndex = 1;
          this.xPanderPanelCache.Text = "cache";
          this.xPanderPanelCache.ToolTipTextCloseIcon = null;
          this.xPanderPanelCache.ToolTipTextExpandIconPanelCollapsed = null;
          this.xPanderPanelCache.ToolTipTextExpandIconPanelExpanded = null;
          this.xPanderPanelCache.Click += new System.EventHandler(this.xPanderPanelCache_Click);
          // 
          // tableLayoutPanel1
          // 
          this.tableLayoutPanel1.ColumnCount = 3;
          this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
          this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
          this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
          this.tableLayoutPanel1.Controls.Add(this.button10, 1, 1);
          this.tableLayoutPanel1.Controls.Add(this.checkBoxUseGeoCache, 1, 11);
          this.tableLayoutPanel1.Controls.Add(this.textBoxMemory, 1, 8);
          this.tableLayoutPanel1.Controls.Add(this.checkBoxUseRouteCache, 1, 10);
          this.tableLayoutPanel1.Controls.Add(this.button9, 1, 2);
          this.tableLayoutPanel1.Controls.Add(this.button11, 1, 3);
          this.tableLayoutPanel1.Controls.Add(this.label10, 1, 7);
          this.tableLayoutPanel1.Controls.Add(this.button2, 1, 5);
          this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
          this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 25);
          this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
          this.tableLayoutPanel1.Name = "tableLayoutPanel1";
          this.tableLayoutPanel1.RowCount = 13;
          this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
          this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
          this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
          this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
          this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
          this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
          this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
          this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
          this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
          this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
          this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
          this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
          this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
          this.tableLayoutPanel1.Size = new System.Drawing.Size(226, 0);
          this.tableLayoutPanel1.TabIndex = 41;
          // 
          // textBoxMemory
          // 
          this.textBoxMemory.Dock = System.Windows.Forms.DockStyle.Top;
          this.textBoxMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.textBoxMemory.Location = new System.Drawing.Point(18, 153);
          this.textBoxMemory.Name = "textBoxMemory";
          this.textBoxMemory.ReadOnly = true;
          this.textBoxMemory.Size = new System.Drawing.Size(190, 28);
          this.textBoxMemory.TabIndex = 39;
          this.textBoxMemory.Text = "...";
          // 
          // label10
          // 
          this.label10.AutoSize = true;
          this.label10.Location = new System.Drawing.Point(18, 137);
          this.label10.Name = "label10";
          this.label10.Size = new System.Drawing.Size(79, 13);
          this.label10.TabIndex = 40;
          this.label10.Text = "memory cache:";
          // 
          // button2
          // 
          this.button2.Dock = System.Windows.Forms.DockStyle.Top;
          this.button2.Location = new System.Drawing.Point(18, 98);
          this.button2.Name = "button2";
          this.button2.Size = new System.Drawing.Size(190, 20);
          this.button2.TabIndex = 43;
          this.button2.Text = "Clear All";
          this.button2.UseVisualStyleBackColor = true;
          this.button2.Click += new System.EventHandler(this.button2_Click);
          // 
          // xPanderPanelInfo
          // 
          this.xPanderPanelInfo.CaptionFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
          this.xPanderPanelInfo.Controls.Add(this.tableLayoutPanel2);
          this.xPanderPanelInfo.CustomColors.BackColor = System.Drawing.SystemColors.Control;
          this.xPanderPanelInfo.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
          this.xPanderPanelInfo.CustomColors.CaptionCheckedGradientBegin = System.Drawing.Color.Empty;
          this.xPanderPanelInfo.CustomColors.CaptionCheckedGradientEnd = System.Drawing.Color.Empty;
          this.xPanderPanelInfo.CustomColors.CaptionCheckedGradientMiddle = System.Drawing.Color.Empty;
          this.xPanderPanelInfo.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
          this.xPanderPanelInfo.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
          this.xPanderPanelInfo.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
          this.xPanderPanelInfo.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
          this.xPanderPanelInfo.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
          this.xPanderPanelInfo.CustomColors.CaptionPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
          this.xPanderPanelInfo.CustomColors.CaptionPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
          this.xPanderPanelInfo.CustomColors.CaptionPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
          this.xPanderPanelInfo.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
          this.xPanderPanelInfo.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
          this.xPanderPanelInfo.CustomColors.CaptionSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
          this.xPanderPanelInfo.CustomColors.CaptionSelectedText = System.Drawing.SystemColors.ControlText;
          this.xPanderPanelInfo.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
          this.xPanderPanelInfo.CustomColors.FlatCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
          this.xPanderPanelInfo.CustomColors.FlatCaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
          this.xPanderPanelInfo.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
          this.xPanderPanelInfo.ForeColor = System.Drawing.SystemColors.ControlText;
          this.xPanderPanelInfo.Image = null;
          this.xPanderPanelInfo.Margin = new System.Windows.Forms.Padding(2);
          this.xPanderPanelInfo.Name = "xPanderPanelInfo";
          this.xPanderPanelInfo.PanelStyle = BSE.Windows.Forms.PanelStyle.Office2007;
          this.xPanderPanelInfo.Size = new System.Drawing.Size(228, 25);
          this.xPanderPanelInfo.TabIndex = 3;
          this.xPanderPanelInfo.Text = "info";
          this.xPanderPanelInfo.ToolTipTextCloseIcon = null;
          this.xPanderPanelInfo.ToolTipTextExpandIconPanelCollapsed = null;
          this.xPanderPanelInfo.ToolTipTextExpandIconPanelExpanded = null;
          this.xPanderPanelInfo.Click += new System.EventHandler(this.xPanderPanelInfo_Click);
          // 
          // tableLayoutPanel2
          // 
          this.tableLayoutPanel2.ColumnCount = 3;
          this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
          this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
          this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
          this.tableLayoutPanel2.Controls.Add(this.textBoxZoomCurrent, 1, 7);
          this.tableLayoutPanel2.Controls.Add(this.textBoxrouteCount, 1, 11);
          this.tableLayoutPanel2.Controls.Add(this.label12, 1, 10);
          this.tableLayoutPanel2.Controls.Add(this.label9, 1, 6);
          this.tableLayoutPanel2.Controls.Add(this.textBoxLngCurrent, 1, 4);
          this.tableLayoutPanel2.Controls.Add(this.textBoxMarkerCount, 1, 9);
          this.tableLayoutPanel2.Controls.Add(this.label11, 1, 8);
          this.tableLayoutPanel2.Controls.Add(this.label4, 1, 3);
          this.tableLayoutPanel2.Controls.Add(this.textBoxLatCurrent, 1, 2);
          this.tableLayoutPanel2.Controls.Add(this.label5, 1, 1);
          this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
          this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 25);
          this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
          this.tableLayoutPanel2.Name = "tableLayoutPanel2";
          this.tableLayoutPanel2.RowCount = 13;
          this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
          this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
          this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
          this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
          this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
          this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
          this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
          this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
          this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
          this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
          this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
          this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
          this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
          this.tableLayoutPanel2.Size = new System.Drawing.Size(226, 0);
          this.tableLayoutPanel2.TabIndex = 14;
          // 
          // textBoxZoomCurrent
          // 
          this.textBoxZoomCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
          this.textBoxZoomCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.textBoxZoomCurrent.Location = new System.Drawing.Point(18, 142);
          this.textBoxZoomCurrent.Name = "textBoxZoomCurrent";
          this.textBoxZoomCurrent.ReadOnly = true;
          this.textBoxZoomCurrent.Size = new System.Drawing.Size(190, 28);
          this.textBoxZoomCurrent.TabIndex = 8;
          this.textBoxZoomCurrent.Text = "...";
          // 
          // textBoxrouteCount
          // 
          this.textBoxrouteCount.Dock = System.Windows.Forms.DockStyle.Fill;
          this.textBoxrouteCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.textBoxrouteCount.Location = new System.Drawing.Point(18, 236);
          this.textBoxrouteCount.Name = "textBoxrouteCount";
          this.textBoxrouteCount.ReadOnly = true;
          this.textBoxrouteCount.Size = new System.Drawing.Size(190, 28);
          this.textBoxrouteCount.TabIndex = 12;
          this.textBoxrouteCount.Text = "...";
          // 
          // label12
          // 
          this.label12.AutoSize = true;
          this.label12.Location = new System.Drawing.Point(18, 220);
          this.label12.Name = "label12";
          this.label12.Size = new System.Drawing.Size(39, 13);
          this.label12.TabIndex = 13;
          this.label12.Text = "routes:";
          // 
          // label9
          // 
          this.label9.AutoSize = true;
          this.label9.Location = new System.Drawing.Point(18, 126);
          this.label9.Name = "label9";
          this.label9.Size = new System.Drawing.Size(35, 13);
          this.label9.TabIndex = 9;
          this.label9.Text = "zoom:";
          // 
          // textBoxLngCurrent
          // 
          this.textBoxLngCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
          this.textBoxLngCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.textBoxLngCurrent.Location = new System.Drawing.Point(18, 79);
          this.textBoxLngCurrent.Name = "textBoxLngCurrent";
          this.textBoxLngCurrent.ReadOnly = true;
          this.textBoxLngCurrent.Size = new System.Drawing.Size(190, 28);
          this.textBoxLngCurrent.TabIndex = 5;
          this.textBoxLngCurrent.Text = "...";
          // 
          // textBoxMarkerCount
          // 
          this.textBoxMarkerCount.Dock = System.Windows.Forms.DockStyle.Fill;
          this.textBoxMarkerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.textBoxMarkerCount.Location = new System.Drawing.Point(18, 189);
          this.textBoxMarkerCount.Name = "textBoxMarkerCount";
          this.textBoxMarkerCount.ReadOnly = true;
          this.textBoxMarkerCount.Size = new System.Drawing.Size(190, 28);
          this.textBoxMarkerCount.TabIndex = 10;
          this.textBoxMarkerCount.Text = "...";
          // 
          // label11
          // 
          this.label11.AutoSize = true;
          this.label11.Location = new System.Drawing.Point(18, 173);
          this.label11.Name = "label11";
          this.label11.Size = new System.Drawing.Size(47, 13);
          this.label11.TabIndex = 11;
          this.label11.Text = "markers:";
          // 
          // label4
          // 
          this.label4.AutoSize = true;
          this.label4.Location = new System.Drawing.Point(18, 63);
          this.label4.Name = "label4";
          this.label4.Size = new System.Drawing.Size(24, 13);
          this.label4.TabIndex = 7;
          this.label4.Text = "lng:";
          // 
          // textBoxLatCurrent
          // 
          this.textBoxLatCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
          this.textBoxLatCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.textBoxLatCurrent.Location = new System.Drawing.Point(18, 32);
          this.textBoxLatCurrent.Name = "textBoxLatCurrent";
          this.textBoxLatCurrent.ReadOnly = true;
          this.textBoxLatCurrent.Size = new System.Drawing.Size(190, 28);
          this.textBoxLatCurrent.TabIndex = 4;
          this.textBoxLatCurrent.Text = "...";
          // 
          // label5
          // 
          this.label5.AutoSize = true;
          this.label5.Location = new System.Drawing.Point(18, 16);
          this.label5.Name = "label5";
          this.label5.Size = new System.Drawing.Size(21, 13);
          this.label5.TabIndex = 6;
          this.label5.Text = "lat:";
          // 
          // xPanderPanelLive
          // 
          this.xPanderPanelLive.CaptionFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
          this.xPanderPanelLive.Controls.Add(this.tableLayoutPanel3);
          this.xPanderPanelLive.CustomColors.BackColor = System.Drawing.SystemColors.Control;
          this.xPanderPanelLive.CustomColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
          this.xPanderPanelLive.CustomColors.CaptionCheckedGradientBegin = System.Drawing.Color.Empty;
          this.xPanderPanelLive.CustomColors.CaptionCheckedGradientEnd = System.Drawing.Color.Empty;
          this.xPanderPanelLive.CustomColors.CaptionCheckedGradientMiddle = System.Drawing.Color.Empty;
          this.xPanderPanelLive.CustomColors.CaptionCloseIcon = System.Drawing.SystemColors.ControlText;
          this.xPanderPanelLive.CustomColors.CaptionExpandIcon = System.Drawing.SystemColors.ControlText;
          this.xPanderPanelLive.CustomColors.CaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
          this.xPanderPanelLive.CustomColors.CaptionGradientEnd = System.Drawing.SystemColors.ButtonFace;
          this.xPanderPanelLive.CustomColors.CaptionGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
          this.xPanderPanelLive.CustomColors.CaptionPressedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
          this.xPanderPanelLive.CustomColors.CaptionPressedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
          this.xPanderPanelLive.CustomColors.CaptionPressedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
          this.xPanderPanelLive.CustomColors.CaptionSelectedGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
          this.xPanderPanelLive.CustomColors.CaptionSelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
          this.xPanderPanelLive.CustomColors.CaptionSelectedGradientMiddle = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
          this.xPanderPanelLive.CustomColors.CaptionSelectedText = System.Drawing.SystemColors.ControlText;
          this.xPanderPanelLive.CustomColors.CaptionText = System.Drawing.SystemColors.ControlText;
          this.xPanderPanelLive.CustomColors.FlatCaptionGradientBegin = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
          this.xPanderPanelLive.CustomColors.FlatCaptionGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
          this.xPanderPanelLive.CustomColors.InnerBorderColor = System.Drawing.SystemColors.Window;
          this.xPanderPanelLive.Expand = true;
          this.xPanderPanelLive.ForeColor = System.Drawing.SystemColors.ControlText;
          this.xPanderPanelLive.Image = null;
          this.xPanderPanelLive.IsClosable = false;
          this.xPanderPanelLive.Margin = new System.Windows.Forms.Padding(2);
          this.xPanderPanelLive.Name = "xPanderPanelLive";
          this.xPanderPanelLive.Padding = new System.Windows.Forms.Padding(0, 0, 0, 24);
          this.xPanderPanelLive.PanelStyle = BSE.Windows.Forms.PanelStyle.Office2007;
          this.xPanderPanelLive.Size = new System.Drawing.Size(228, 628);
          this.xPanderPanelLive.TabIndex = 2;
          this.xPanderPanelLive.Text = "chase mode";
          this.xPanderPanelLive.ToolTipTextCloseIcon = null;
          this.xPanderPanelLive.ToolTipTextExpandIconPanelCollapsed = null;
          this.xPanderPanelLive.ToolTipTextExpandIconPanelExpanded = null;
          this.xPanderPanelLive.Click += new System.EventHandler(this.xPanderPanelLive_Click);
          // 
          // tableLayoutPanel3
          // 
          this.tableLayoutPanel3.ColumnCount = 4;
          this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
          this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
          this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
          this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
          this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
          this.tableLayoutPanel3.Controls.Add(this.buttonLoadKML, 1, 5);
          this.tableLayoutPanel3.Controls.Add(this.buttonConnectGPS, 2, 7);
          this.tableLayoutPanel3.Controls.Add(this.comboBoxCOMPorts, 1, 7);
          this.tableLayoutPanel3.Controls.Add(this.textBoxGPSData, 1, 8);
          this.tableLayoutPanel3.Controls.Add(this.comboBoxGPSType, 1, 6);
          this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
          this.tableLayoutPanel3.Location = new System.Drawing.Point(1, 25);
          this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
          this.tableLayoutPanel3.Name = "tableLayoutPanel3";
          this.tableLayoutPanel3.RowCount = 12;
          this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
          this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
          this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
          this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
          this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
          this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
          this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
          this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
          this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
          this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
          this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
          this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
          this.tableLayoutPanel3.Size = new System.Drawing.Size(226, 579);
          this.tableLayoutPanel3.TabIndex = 6;
          // 
          // buttonLoadKML
          // 
          this.buttonLoadKML.Location = new System.Drawing.Point(18, 19);
          this.buttonLoadKML.Name = "buttonLoadKML";
          this.buttonLoadKML.Size = new System.Drawing.Size(82, 23);
          this.buttonLoadKML.TabIndex = 17;
          this.buttonLoadKML.Text = "Load KML...";
          this.buttonLoadKML.UseVisualStyleBackColor = true;
          this.buttonLoadKML.Click += new System.EventHandler(this.button17_Click);
          // 
          // buttonConnectGPS
          // 
          this.buttonConnectGPS.Location = new System.Drawing.Point(147, 68);
          this.buttonConnectGPS.Name = "buttonConnectGPS";
          this.buttonConnectGPS.Size = new System.Drawing.Size(58, 19);
          this.buttonConnectGPS.TabIndex = 19;
          this.buttonConnectGPS.Text = "Connect";
          this.buttonConnectGPS.UseVisualStyleBackColor = true;
          this.buttonConnectGPS.Click += new System.EventHandler(this.buttonConnectGPS_Click);
          // 
          // comboBoxCOMPorts
          // 
          this.comboBoxCOMPorts.FormattingEnabled = true;
          this.comboBoxCOMPorts.Location = new System.Drawing.Point(18, 68);
          this.comboBoxCOMPorts.Name = "comboBoxCOMPorts";
          this.comboBoxCOMPorts.Size = new System.Drawing.Size(121, 21);
          this.comboBoxCOMPorts.TabIndex = 20;
          // 
          // textBoxGPSData
          // 
          this.tableLayoutPanel3.SetColumnSpan(this.textBoxGPSData, 2);
          this.textBoxGPSData.Dock = System.Windows.Forms.DockStyle.Fill;
          this.textBoxGPSData.Location = new System.Drawing.Point(18, 93);
          this.textBoxGPSData.Multiline = true;
          this.textBoxGPSData.Name = "textBoxGPSData";
          this.textBoxGPSData.Size = new System.Drawing.Size(190, 463);
          this.textBoxGPSData.TabIndex = 21;
          // 
          // panel2
          // 
          this.panel2.Controls.Add(this.MainMap);
          this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
          this.panel2.Location = new System.Drawing.Point(0, 0);
          this.panel2.Margin = new System.Windows.Forms.Padding(2);
          this.panel2.Name = "panel2";
          this.panel2.Size = new System.Drawing.Size(660, 732);
          this.panel2.TabIndex = 41;
          // 
          // MainMap
          // 
          this.MainMap.Bearing = 0F;
          this.MainMap.CanDragMap = true;
          this.MainMap.Dock = System.Windows.Forms.DockStyle.Fill;
          this.MainMap.GrayScaleMode = false;
          this.MainMap.LevelsKeepInMemmory = 5;
          this.MainMap.Location = new System.Drawing.Point(0, 0);
          this.MainMap.MarkersEnabled = true;
          this.MainMap.MaxZoom = 17;
          this.MainMap.MinZoom = 2;
          this.MainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
          this.MainMap.Name = "MainMap";
          this.MainMap.NegativeMode = false;
          this.MainMap.PolygonsEnabled = true;
          this.MainMap.RetryLoadTile = 0;
          this.MainMap.RoutesEnabled = true;
          this.MainMap.ShowTileGridLines = false;
          this.MainMap.Size = new System.Drawing.Size(660, 732);
          this.MainMap.TabIndex = 0;
          this.MainMap.Zoom = 0D;
          // 
          // panel4
          // 
          this.panel4.Controls.Add(this.panel2);
          this.panel4.Controls.Add(this.splitter1);
          this.panel4.Controls.Add(this.panelMenu);
          this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
          this.panel4.Location = new System.Drawing.Point(0, 0);
          this.panel4.Margin = new System.Windows.Forms.Padding(2);
          this.panel4.Name = "panel4";
          this.panel4.Size = new System.Drawing.Size(890, 732);
          this.panel4.TabIndex = 44;
          // 
          // comboBoxGPSType
          // 
          this.comboBoxGPSType.FormattingEnabled = true;
          this.comboBoxGPSType.Items.AddRange(new object[] {
            "USB GPS",
            "Arduino GPS"});
          this.comboBoxGPSType.Location = new System.Drawing.Point(18, 48);
          this.comboBoxGPSType.Name = "comboBoxGPSType";
          this.comboBoxGPSType.Size = new System.Drawing.Size(121, 21);
          this.comboBoxGPSType.TabIndex = 22;
          // 
          // MainForm
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.BackColor = System.Drawing.Color.AliceBlue;
          this.ClientSize = new System.Drawing.Size(890, 732);
          this.Controls.Add(this.panel4);
          this.KeyPreview = true;
          this.MinimumSize = new System.Drawing.Size(554, 107);
          this.Name = "MainForm";
          this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
          this.Text = "GMap.NET - Great Maps for Windows Forms";
          this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
          this.Load += new System.EventHandler(this.MainForm_Load);
          this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
          this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
          this.groupBox3.ResumeLayout(false);
          this.groupBox3.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
          this.groupBox5.ResumeLayout(false);
          this.groupBox5.PerformLayout();
          this.groupBox7.ResumeLayout(false);
          this.groupBox7.PerformLayout();
          this.groupBox8.ResumeLayout(false);
          this.groupBox8.PerformLayout();
          this.panelMenu.ResumeLayout(false);
          this.xPanderPanelList1.ResumeLayout(false);
          this.xPanderPanelMain.ResumeLayout(false);
          this.tableLayoutPanel4.ResumeLayout(false);
          this.tableLayoutPanel4.PerformLayout();
          this.tableLayoutPanel5.ResumeLayout(false);
          this.xPanderPanelCache.ResumeLayout(false);
          this.tableLayoutPanel1.ResumeLayout(false);
          this.tableLayoutPanel1.PerformLayout();
          this.xPanderPanelInfo.ResumeLayout(false);
          this.tableLayoutPanel2.ResumeLayout(false);
          this.tableLayoutPanel2.PerformLayout();
          this.xPanderPanelLive.ResumeLayout(false);
          this.tableLayoutPanel3.ResumeLayout(false);
          this.tableLayoutPanel3.PerformLayout();
          this.panel2.ResumeLayout(false);
          this.panel4.ResumeLayout(false);
          this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox textBoxLng;
      private System.Windows.Forms.TextBox textBoxLat;
      private System.Windows.Forms.Button button8;
      private System.Windows.Forms.ComboBox comboBoxMapType;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.TrackBar trackBar1;
      private System.Windows.Forms.GroupBox groupBox5;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.TextBox textBoxGeo;
      private System.Windows.Forms.Button button3;
      private System.Windows.Forms.Button button4;
      private System.Windows.Forms.Button button5;
      private System.Windows.Forms.GroupBox groupBox7;
      private System.Windows.Forms.Button button6;
      private System.Windows.Forms.CheckBox checkBoxUseGeoCache;
      private System.Windows.Forms.CheckBox checkBoxUseRouteCache;
      private System.Windows.Forms.GroupBox groupBox8;
      private System.Windows.Forms.CheckBox checkBoxCurrentMarker;
      private System.Windows.Forms.CheckBox checkBoxCanDrag;
      private System.Windows.Forms.Button buttonSetEnd;
      private System.Windows.Forms.Button buttonSetStart;
      private System.Windows.Forms.CheckBox checkBoxPlacemarkInfo;
      private System.Windows.Forms.Button button7;
      private System.Windows.Forms.Button button9;
      private System.Windows.Forms.Button button10;
      private System.Windows.Forms.Button button11;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.ComboBox comboBoxMode;
      private System.Windows.Forms.Button button12;
      private System.Windows.Forms.CheckBox checkBoxDebug;
      private System.Windows.Forms.Button button13;
      private System.Windows.Forms.Button button14;
      private System.Windows.Forms.DateTimePicker MobileLogFrom;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button button15;
      private System.Windows.Forms.DateTimePicker MobileLogTo;
      private System.Windows.Forms.Button buttonExportToGpx;
      internal Map MainMap;
      private System.Windows.Forms.Button button16;
      private BSE.Windows.Forms.Panel panelMenu;
      private BSE.Windows.Forms.XPanderPanelList xPanderPanelList1;
      private BSE.Windows.Forms.XPanderPanel xPanderPanelMain;
      private BSE.Windows.Forms.XPanderPanel xPanderPanelCache;
      private BSE.Windows.Forms.XPanderPanel xPanderPanelLive;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Panel panel4;
      private BSE.Windows.Forms.Splitter splitter1;
      private BSE.Windows.Forms.XPanderPanel xPanderPanelInfo;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox textBoxLngCurrent;
      private System.Windows.Forms.TextBox textBoxLatCurrent;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.TextBox textBoxZoomCurrent;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.TextBox textBoxMemory;
      private System.Windows.Forms.Label label12;
      private System.Windows.Forms.TextBox textBoxrouteCount;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.TextBox textBoxMarkerCount;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button buttonLoadKML;
      private System.Windows.Forms.Button buttonConnectGPS;
      private System.Windows.Forms.ComboBox comboBoxCOMPorts;
      private System.Windows.Forms.TextBox textBoxGPSData;
      private System.Windows.Forms.ComboBox comboBoxGPSType;
   }
}

