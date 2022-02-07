namespace FahrplanApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabConnections = new System.Windows.Forms.TabPage();
            this.btnShare = new System.Windows.Forms.Button();
            this.lbTo = new System.Windows.Forms.ListBox();
            this.lbFrom = new System.Windows.Forms.ListBox();
            this.labelConnection = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvConnections = new System.Windows.Forms.DataGridView();
            this.dateOfDepartureColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.btnConnections = new System.Windows.Forms.Button();
            this.tabStationboard = new System.Windows.Forms.TabPage();
            this.lbStationboard = new System.Windows.Forms.ListBox();
            this.labelStationboard = new System.Windows.Forms.Label();
            this.btnStationboard = new System.Windows.Forms.Button();
            this.txtStationboard = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvStationboard = new System.Windows.Forms.DataGridView();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformColumnSB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endstationColumnSB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureColumnSB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMap = new System.Windows.Forms.TabPage();
            this.lbPlace = new System.Windows.Forms.ListBox();
            this.btnCloseMap = new System.Windows.Forms.Button();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.btnCloseBy = new System.Windows.Forms.Button();
            this.labelPlace = new System.Windows.Forms.Label();
            this.btnPlace = new System.Windows.Forms.Button();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.dgvMap = new System.Windows.Forms.DataGridView();
            this.nameColumnMap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.tabMail = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabConnections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).BeginInit();
            this.tabStationboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationboard)).BeginInit();
            this.tabMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMap)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabConnections);
            this.tabControl.Controls.Add(this.tabStationboard);
            this.tabControl.Controls.Add(this.tabMap);
            this.tabControl.Controls.Add(this.tabMail);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(783, 805);
            this.tabControl.TabIndex = 0;
            // 
            // tabConnections
            // 
            this.tabConnections.Controls.Add(this.btnShare);
            this.tabConnections.Controls.Add(this.lbTo);
            this.tabConnections.Controls.Add(this.lbFrom);
            this.tabConnections.Controls.Add(this.labelConnection);
            this.tabConnections.Controls.Add(this.datePicker);
            this.tabConnections.Controls.Add(this.label4);
            this.tabConnections.Controls.Add(this.label3);
            this.tabConnections.Controls.Add(this.dgvConnections);
            this.tabConnections.Controls.Add(this.label2);
            this.tabConnections.Controls.Add(this.label1);
            this.tabConnections.Controls.Add(this.timePicker);
            this.tabConnections.Controls.Add(this.txtTo);
            this.tabConnections.Controls.Add(this.txtFrom);
            this.tabConnections.Controls.Add(this.btnConnections);
            this.tabConnections.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabConnections.Location = new System.Drawing.Point(4, 30);
            this.tabConnections.Name = "tabConnections";
            this.tabConnections.Padding = new System.Windows.Forms.Padding(3);
            this.tabConnections.Size = new System.Drawing.Size(775, 771);
            this.tabConnections.TabIndex = 0;
            this.tabConnections.Text = "Verbindungen";
            this.tabConnections.UseVisualStyleBackColor = true;
            this.tabConnections.Click += new System.EventHandler(this.closeLists);
            // 
            // btnShare
            // 
            this.btnShare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShare.Location = new System.Drawing.Point(600, 309);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(141, 71);
            this.btnShare.TabIndex = 14;
            this.btnShare.Text = "Ausgewählte Verbindung teilen";
            this.btnShare.UseVisualStyleBackColor = true;
            this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
            // 
            // lbTo
            // 
            this.lbTo.FormattingEnabled = true;
            this.lbTo.ItemHeight = 21;
            this.lbTo.Location = new System.Drawing.Point(419, 111);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(259, 172);
            this.lbTo.TabIndex = 13;
            this.lbTo.Click += new System.EventHandler(this.lbTo_Click);
            // 
            // lbFrom
            // 
            this.lbFrom.FormattingEnabled = true;
            this.lbFrom.HorizontalScrollbar = true;
            this.lbFrom.ItemHeight = 21;
            this.lbFrom.Location = new System.Drawing.Point(106, 111);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(259, 172);
            this.lbFrom.TabIndex = 12;
            this.lbFrom.Click += new System.EventHandler(this.lbFrom_Click);
            this.lbFrom.Leave += new System.EventHandler(this.lbFrom_Leave);
            // 
            // labelConnection
            // 
            this.labelConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelConnection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelConnection.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelConnection.Location = new System.Drawing.Point(33, 313);
            this.labelConnection.Name = "labelConnection";
            this.labelConnection.Size = new System.Drawing.Size(446, 70);
            this.labelConnection.TabIndex = 11;
            this.labelConnection.Text = "Verbindungen";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(106, 144);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 29);
            this.datePicker.TabIndex = 3;
            this.datePicker.Enter += new System.EventHandler(this.closeLists);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Uhrzeit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Datum:";
            // 
            // dgvConnections
            // 
            this.dgvConnections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateOfDepartureColumn,
            this.platformColumn,
            this.departureColumn,
            this.arrivalColumn});
            this.dgvConnections.Location = new System.Drawing.Point(-4, 386);
            this.dgvConnections.Name = "dgvConnections";
            this.dgvConnections.RowTemplate.Height = 25;
            this.dgvConnections.Size = new System.Drawing.Size(783, 389);
            this.dgvConnections.TabIndex = 6;
            // 
            // dateOfDepartureColumn
            // 
            this.dateOfDepartureColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateOfDepartureColumn.FillWeight = 200F;
            this.dateOfDepartureColumn.HeaderText = "Abfahrtsdatum";
            this.dateOfDepartureColumn.Name = "dateOfDepartureColumn";
            this.dateOfDepartureColumn.ReadOnly = true;
            // 
            // platformColumn
            // 
            this.platformColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.platformColumn.HeaderText = "Gleis";
            this.platformColumn.Name = "platformColumn";
            this.platformColumn.ReadOnly = true;
            // 
            // departureColumn
            // 
            this.departureColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departureColumn.FillWeight = 150F;
            this.departureColumn.HeaderText = "Abfahrt";
            this.departureColumn.Name = "departureColumn";
            this.departureColumn.ReadOnly = true;
            // 
            // arrivalColumn
            // 
            this.arrivalColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.arrivalColumn.FillWeight = 150F;
            this.arrivalColumn.HeaderText = "Ankunft";
            this.arrivalColumn.Name = "arrivalColumn";
            this.arrivalColumn.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nach:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Von:";
            // 
            // timePicker
            // 
            this.timePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.timePicker.Location = new System.Drawing.Point(419, 144);
            this.timePicker.Name = "timePicker";
            this.timePicker.Size = new System.Drawing.Size(72, 29);
            this.timePicker.TabIndex = 4;
            this.timePicker.Enter += new System.EventHandler(this.closeLists);
            // 
            // txtTo
            // 
            this.txtTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTo.Location = new System.Drawing.Point(419, 87);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(146, 29);
            this.txtTo.TabIndex = 2;
            this.txtTo.TextChanged += new System.EventHandler(this.txtTo_TextChanged);
            this.txtTo.Enter += new System.EventHandler(this.txtTo_Enter);
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(106, 87);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(146, 29);
            this.txtFrom.TabIndex = 1;
            this.txtFrom.TextChanged += new System.EventHandler(this.txtFrom_TextChanged);
            this.txtFrom.Enter += new System.EventHandler(this.txtFrom_Enter);
            // 
            // btnConnections
            // 
            this.btnConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnections.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnections.Location = new System.Drawing.Point(600, 65);
            this.btnConnections.Name = "btnConnections";
            this.btnConnections.Size = new System.Drawing.Size(141, 71);
            this.btnConnections.TabIndex = 5;
            this.btnConnections.Text = "Verbindungen suchen";
            this.btnConnections.UseVisualStyleBackColor = true;
            this.btnConnections.Click += new System.EventHandler(this.btnConnections_Click);
            // 
            // tabStationboard
            // 
            this.tabStationboard.Controls.Add(this.lbStationboard);
            this.tabStationboard.Controls.Add(this.labelStationboard);
            this.tabStationboard.Controls.Add(this.btnStationboard);
            this.tabStationboard.Controls.Add(this.txtStationboard);
            this.tabStationboard.Controls.Add(this.label5);
            this.tabStationboard.Controls.Add(this.dgvStationboard);
            this.tabStationboard.Location = new System.Drawing.Point(4, 30);
            this.tabStationboard.Name = "tabStationboard";
            this.tabStationboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabStationboard.Size = new System.Drawing.Size(775, 771);
            this.tabStationboard.TabIndex = 1;
            this.tabStationboard.Text = "Abfahrtstafel";
            this.tabStationboard.UseVisualStyleBackColor = true;
            this.tabStationboard.Click += new System.EventHandler(this.closeLists);
            // 
            // lbStationboard
            // 
            this.lbStationboard.FormattingEnabled = true;
            this.lbStationboard.ItemHeight = 21;
            this.lbStationboard.Location = new System.Drawing.Point(249, 146);
            this.lbStationboard.Name = "lbStationboard";
            this.lbStationboard.Size = new System.Drawing.Size(259, 172);
            this.lbStationboard.TabIndex = 5;
            this.lbStationboard.Click += new System.EventHandler(this.lbStationboard_Click);
            // 
            // labelStationboard
            // 
            this.labelStationboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStationboard.AutoSize = true;
            this.labelStationboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStationboard.Location = new System.Drawing.Point(35, 362);
            this.labelStationboard.Name = "labelStationboard";
            this.labelStationboard.Size = new System.Drawing.Size(175, 21);
            this.labelStationboard.TabIndex = 4;
            this.labelStationboard.Text = "Aktuelle Anzeigetafel";
            // 
            // btnStationboard
            // 
            this.btnStationboard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStationboard.Location = new System.Drawing.Point(514, 97);
            this.btnStationboard.Name = "btnStationboard";
            this.btnStationboard.Size = new System.Drawing.Size(141, 71);
            this.btnStationboard.TabIndex = 3;
            this.btnStationboard.Text = "Anzeigetafel suchen";
            this.btnStationboard.UseVisualStyleBackColor = true;
            this.btnStationboard.Click += new System.EventHandler(this.btnStationboard_Click);
            // 
            // txtStationboard
            // 
            this.txtStationboard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStationboard.Location = new System.Drawing.Point(249, 119);
            this.txtStationboard.Name = "txtStationboard";
            this.txtStationboard.Size = new System.Drawing.Size(259, 29);
            this.txtStationboard.TabIndex = 2;
            this.txtStationboard.TextChanged += new System.EventHandler(this.txtStationboard_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Station:";
            // 
            // dgvStationboard
            // 
            this.dgvStationboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStationboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStationboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumn,
            this.platformColumnSB,
            this.endstationColumnSB,
            this.departureColumnSB});
            this.dgvStationboard.Location = new System.Drawing.Point(-4, 386);
            this.dgvStationboard.Name = "dgvStationboard";
            this.dgvStationboard.RowTemplate.Height = 25;
            this.dgvStationboard.Size = new System.Drawing.Size(783, 389);
            this.dgvStationboard.TabIndex = 0;
            // 
            // nameColumn
            // 
            this.nameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn.FillWeight = 150F;
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // platformColumnSB
            // 
            this.platformColumnSB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.platformColumnSB.HeaderText = "Gleis";
            this.platformColumnSB.Name = "platformColumnSB";
            this.platformColumnSB.ReadOnly = true;
            // 
            // endstationColumnSB
            // 
            this.endstationColumnSB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.endstationColumnSB.FillWeight = 200F;
            this.endstationColumnSB.HeaderText = "Endstation";
            this.endstationColumnSB.Name = "endstationColumnSB";
            this.endstationColumnSB.ReadOnly = true;
            // 
            // departureColumnSB
            // 
            this.departureColumnSB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departureColumnSB.FillWeight = 150F;
            this.departureColumnSB.HeaderText = "Abfahrt";
            this.departureColumnSB.Name = "departureColumnSB";
            this.departureColumnSB.ReadOnly = true;
            // 
            // tabMap
            // 
            this.tabMap.Controls.Add(this.lbPlace);
            this.tabMap.Controls.Add(this.btnCloseMap);
            this.tabMap.Controls.Add(this.gmap);
            this.tabMap.Controls.Add(this.btnCloseBy);
            this.tabMap.Controls.Add(this.labelPlace);
            this.tabMap.Controls.Add(this.btnPlace);
            this.tabMap.Controls.Add(this.txtPlace);
            this.tabMap.Controls.Add(this.dgvMap);
            this.tabMap.Controls.Add(this.label6);
            this.tabMap.Location = new System.Drawing.Point(4, 30);
            this.tabMap.Name = "tabMap";
            this.tabMap.Padding = new System.Windows.Forms.Padding(3);
            this.tabMap.Size = new System.Drawing.Size(775, 771);
            this.tabMap.TabIndex = 2;
            this.tabMap.Text = "Karte";
            this.tabMap.UseVisualStyleBackColor = true;
            this.tabMap.Click += new System.EventHandler(this.closeLists);
            // 
            // lbPlace
            // 
            this.lbPlace.FormattingEnabled = true;
            this.lbPlace.ItemHeight = 21;
            this.lbPlace.Location = new System.Drawing.Point(249, 147);
            this.lbPlace.Name = "lbPlace";
            this.lbPlace.Size = new System.Drawing.Size(259, 172);
            this.lbPlace.TabIndex = 8;
            this.lbPlace.Click += new System.EventHandler(this.lbPlace_Click);
            // 
            // btnCloseMap
            // 
            this.btnCloseMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseMap.Location = new System.Drawing.Point(672, 397);
            this.btnCloseMap.Name = "btnCloseMap";
            this.btnCloseMap.Size = new System.Drawing.Size(97, 52);
            this.btnCloseMap.TabIndex = 7;
            this.btnCloseMap.Text = "Zurück zur Auswahl";
            this.btnCloseMap.UseVisualStyleBackColor = true;
            this.btnCloseMap.Click += new System.EventHandler(this.btnCloseMap_Click);
            // 
            // gmap
            // 
            this.gmap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemory = 5;
            this.gmap.Location = new System.Drawing.Point(-4, 386);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 18;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(783, 389);
            this.gmap.TabIndex = 6;
            this.gmap.Zoom = 9D;
            // 
            // btnCloseBy
            // 
            this.btnCloseBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseBy.Location = new System.Drawing.Point(628, 309);
            this.btnCloseBy.Name = "btnCloseBy";
            this.btnCloseBy.Size = new System.Drawing.Size(141, 71);
            this.btnCloseBy.TabIndex = 5;
            this.btnCloseBy.Text = "Station in der Nähe";
            this.btnCloseBy.UseVisualStyleBackColor = true;
            this.btnCloseBy.Click += new System.EventHandler(this.btnCloseBy_Click);
            // 
            // labelPlace
            // 
            this.labelPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPlace.AutoSize = true;
            this.labelPlace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlace.Location = new System.Drawing.Point(35, 362);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(84, 21);
            this.labelPlace.TabIndex = 4;
            this.labelPlace.Text = "Stationen";
            // 
            // btnPlace
            // 
            this.btnPlace.Location = new System.Drawing.Point(514, 97);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(141, 71);
            this.btnPlace.TabIndex = 3;
            this.btnPlace.Text = "Stationen suchen";
            this.btnPlace.UseVisualStyleBackColor = true;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(249, 119);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(259, 29);
            this.txtPlace.TabIndex = 2;
            this.txtPlace.TextChanged += new System.EventHandler(this.txtPlace_TextChanged);
            // 
            // dgvMap
            // 
            this.dgvMap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameColumnMap});
            this.dgvMap.Location = new System.Drawing.Point(-4, 386);
            this.dgvMap.Name = "dgvMap";
            this.dgvMap.RowTemplate.Height = 25;
            this.dgvMap.Size = new System.Drawing.Size(783, 389);
            this.dgvMap.TabIndex = 1;
            this.dgvMap.Click += new System.EventHandler(this.dgvMap_Click);
            // 
            // nameColumnMap
            // 
            this.nameColumnMap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumnMap.HeaderText = "Name";
            this.nameColumnMap.Name = "nameColumnMap";
            this.nameColumnMap.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ort:";
            // 
            // tabMail
            // 
            this.tabMail.Location = new System.Drawing.Point(4, 30);
            this.tabMail.Name = "tabMail";
            this.tabMail.Padding = new System.Windows.Forms.Padding(3);
            this.tabMail.Size = new System.Drawing.Size(775, 771);
            this.tabMail.TabIndex = 3;
            this.tabMail.Text = "Verbindung teilen";
            this.tabMail.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(807, 829);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "FahrplanApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabConnections.ResumeLayout(false);
            this.tabConnections.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).EndInit();
            this.tabStationboard.ResumeLayout(false);
            this.tabStationboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationboard)).EndInit();
            this.tabMap.ResumeLayout(false);
            this.tabMap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage tabStationboard;
        private TabPage tabConnections;
        private Button btnConnections;
        private TabPage tabMap;
        private TextBox txtTo;
        private TextBox txtFrom;
        private DateTimePicker timePicker;
        private Label label1;
        private Label label2;
        private DataGridView dgvConnections;
        private Label label4;
        private Label label3;
        private DateTimePicker datePicker;
        private DataGridView dgvStationboard;
        private Label label5;
        private Label labelConnection;
        private TextBox txtStationboard;
        private Button btnStationboard;
        private Label labelStationboard;
        private DataGridViewTextBoxColumn dateOfDepartureColumn;
        private DataGridViewTextBoxColumn platformColumn;
        private DataGridViewTextBoxColumn departureColumn;
        private DataGridViewTextBoxColumn arrivalColumn;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn platformColumnSB;
        private DataGridViewTextBoxColumn endstationColumnSB;
        private DataGridViewTextBoxColumn departureColumnSB;
        private ListBox lbTo;
        private ListBox lbFrom;
        private ListBox lbStationboard;
        private DataGridView dgvMap;
        private DataGridViewTextBoxColumn nameColumnMap;
        private Label label6;
        private Label labelPlace;
        private Button btnPlace;
        private TextBox txtPlace;
        private Button btnCloseBy;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private Button btnCloseMap;
        private ListBox lbPlace;
        private Button btnShare;
        private TabPage tabMail;
    }
}