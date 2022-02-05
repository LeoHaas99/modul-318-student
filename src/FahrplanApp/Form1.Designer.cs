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
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationboard)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(783, 805);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbTo);
            this.tabPage1.Controls.Add(this.lbFrom);
            this.tabPage1.Controls.Add(this.labelConnection);
            this.tabPage1.Controls.Add(this.datePicker);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dgvConnections);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.timePicker);
            this.tabPage1.Controls.Add(this.txtTo);
            this.tabPage1.Controls.Add(this.txtFrom);
            this.tabPage1.Controls.Add(this.btnConnections);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(775, 771);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Verbindungen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbTo
            // 
            this.lbTo.FormattingEnabled = true;
            this.lbTo.ItemHeight = 21;
            this.lbTo.Location = new System.Drawing.Point(419, 112);
            this.lbTo.Name = "lbTo";
            this.lbTo.Size = new System.Drawing.Size(146, 172);
            this.lbTo.TabIndex = 13;
            // 
            // lbFrom
            // 
            this.lbFrom.FormattingEnabled = true;
            this.lbFrom.ItemHeight = 21;
            this.lbFrom.Location = new System.Drawing.Point(85, 112);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.Size = new System.Drawing.Size(147, 172);
            this.lbFrom.TabIndex = 12;
            // 
            // labelConnection
            // 
            this.labelConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelConnection.AutoSize = true;
            this.labelConnection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelConnection.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelConnection.Location = new System.Drawing.Point(35, 348);
            this.labelConnection.Name = "labelConnection";
            this.labelConnection.Size = new System.Drawing.Size(119, 21);
            this.labelConnection.TabIndex = 11;
            this.labelConnection.Text = "Verbindungen";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(86, 144);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 29);
            this.datePicker.TabIndex = 10;
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
            this.label3.Location = new System.Drawing.Point(20, 150);
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
            this.dgvConnections.TabIndex = 7;
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
            // 
            // txtTo
            // 
            this.txtTo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTo.Location = new System.Drawing.Point(419, 87);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(146, 29);
            this.txtTo.TabIndex = 2;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(86, 87);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(146, 29);
            this.txtFrom.TabIndex = 1;
            // 
            // btnConnections
            // 
            this.btnConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnections.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnections.Location = new System.Drawing.Point(600, 65);
            this.btnConnections.Name = "btnConnections";
            this.btnConnections.Size = new System.Drawing.Size(141, 71);
            this.btnConnections.TabIndex = 0;
            this.btnConnections.Text = "Verbindungen suchen";
            this.btnConnections.UseVisualStyleBackColor = true;
            this.btnConnections.Click += new System.EventHandler(this.btnConnections_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbStationboard);
            this.tabPage2.Controls.Add(this.labelStationboard);
            this.tabPage2.Controls.Add(this.btnStationboard);
            this.tabPage2.Controls.Add(this.txtStationboard);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dgvStationboard);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(775, 771);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Abfahrtstafel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbStationboard
            // 
            this.lbStationboard.FormattingEnabled = true;
            this.lbStationboard.ItemHeight = 21;
            this.lbStationboard.Location = new System.Drawing.Point(272, 144);
            this.lbStationboard.Name = "lbStationboard";
            this.lbStationboard.Size = new System.Drawing.Size(141, 151);
            this.lbStationboard.TabIndex = 5;
            // 
            // labelStationboard
            // 
            this.labelStationboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStationboard.AutoSize = true;
            this.labelStationboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStationboard.Location = new System.Drawing.Point(35, 348);
            this.labelStationboard.Name = "labelStationboard";
            this.labelStationboard.Size = new System.Drawing.Size(175, 21);
            this.labelStationboard.TabIndex = 4;
            this.labelStationboard.Text = "Aktuelle Anzeigetafel";
            // 
            // btnStationboard
            // 
            this.btnStationboard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStationboard.Location = new System.Drawing.Point(425, 97);
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
            this.txtStationboard.Location = new System.Drawing.Point(272, 118);
            this.txtStationboard.Name = "txtStationboard";
            this.txtStationboard.Size = new System.Drawing.Size(141, 29);
            this.txtStationboard.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 122);
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
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(775, 771);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Karte";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStationboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private Button btnConnections;
        private TabPage tabPage3;
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
    }
}