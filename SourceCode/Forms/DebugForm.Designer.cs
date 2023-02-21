namespace HynusWynus_BackupManager.Forms
{
    partial class DebugForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebugForm));
            this.MinimizeWindow = new System.Windows.Forms.Button();
            this.CloseWindow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SettingsElements = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateDebugLog = new System.Windows.Forms.CheckBox();
            this.OpenDebugLog = new System.Windows.Forms.Button();
            this.RefreshRate = new System.Windows.Forms.Timer(this.components);
            this.MinSeverity = new System.Windows.Forms.ComboBox();
            this.severityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.severityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // MinimizeWindow
            // 
            this.MinimizeWindow.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeWindow.FlatAppearance.BorderSize = 0;
            this.MinimizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeWindow.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeWindow.ForeColor = System.Drawing.SystemColors.Control;
            this.MinimizeWindow.Location = new System.Drawing.Point(408, -6);
            this.MinimizeWindow.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeWindow.Name = "MinimizeWindow";
            this.MinimizeWindow.Size = new System.Drawing.Size(39, 34);
            this.MinimizeWindow.TabIndex = 6;
            this.MinimizeWindow.Text = "−";
            this.MinimizeWindow.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MinimizeWindow.UseVisualStyleBackColor = false;
            this.MinimizeWindow.Click += new System.EventHandler(this.MinimizeWindow_Click);
            // 
            // CloseWindow
            // 
            this.CloseWindow.BackColor = System.Drawing.Color.Transparent;
            this.CloseWindow.FlatAppearance.BorderSize = 0;
            this.CloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseWindow.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseWindow.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseWindow.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CloseWindow.Location = new System.Drawing.Point(446, -6);
            this.CloseWindow.Margin = new System.Windows.Forms.Padding(2);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(39, 34);
            this.CloseWindow.TabIndex = 5;
            this.CloseWindow.Text = "X";
            this.CloseWindow.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CloseWindow.UseVisualStyleBackColor = false;
            this.CloseWindow.Click += new System.EventHandler(this.CloseWindow_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.MinimizeWindow);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.CloseWindow);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 25);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragMouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragMouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Debug Window";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(121, 25);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(367, 305);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(121, 25);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(369, 315);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragMouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragMouseUp);
            // 
            // SettingsElements
            // 
            this.SettingsElements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SettingsElements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SettingsElements.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsElements.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SettingsElements.Location = new System.Drawing.Point(20, 60);
            this.SettingsElements.Name = "SettingsElements";
            this.SettingsElements.ReadOnly = true;
            this.SettingsElements.Size = new System.Drawing.Size(243, 311);
            this.SettingsElements.TabIndex = 2;
            this.SettingsElements.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Settings:";
            // 
            // CreateDebugLog
            // 
            this.CreateDebugLog.AutoSize = true;
            this.CreateDebugLog.Location = new System.Drawing.Point(284, 63);
            this.CreateDebugLog.Name = "CreateDebugLog";
            this.CreateDebugLog.Size = new System.Drawing.Size(137, 21);
            this.CreateDebugLog.TabIndex = 5;
            this.CreateDebugLog.Text = "Create Debug Log";
            this.CreateDebugLog.UseVisualStyleBackColor = true;
            this.CreateDebugLog.CheckedChanged += new System.EventHandler(this.CreateDebugLog_CheckedChanged);
            // 
            // OpenDebugLog
            // 
            this.OpenDebugLog.FlatAppearance.BorderSize = 0;
            this.OpenDebugLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenDebugLog.Location = new System.Drawing.Point(284, 145);
            this.OpenDebugLog.Name = "OpenDebugLog";
            this.OpenDebugLog.Size = new System.Drawing.Size(135, 25);
            this.OpenDebugLog.TabIndex = 6;
            this.OpenDebugLog.Text = "Open Debug Log";
            this.OpenDebugLog.UseVisualStyleBackColor = true;
            this.OpenDebugLog.Click += new System.EventHandler(this.OpenDebugLog_Click);
            // 
            // RefreshRate
            // 
            this.RefreshRate.Enabled = true;
            this.RefreshRate.Tick += new System.EventHandler(this.RefreshRate_Tick);
            // 
            // MinSeverity
            // 
            this.MinSeverity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MinSeverity.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MinSeverity.FormattingEnabled = true;
            this.MinSeverity.Items.AddRange(new object[] {
            "Log (0)",
            "Info (1)",
            "Warning (2)",
            "Error (3)"});
            this.MinSeverity.Location = new System.Drawing.Point(285, 100);
            this.MinSeverity.Name = "MinSeverity";
            this.MinSeverity.Size = new System.Drawing.Size(120, 25);
            this.MinSeverity.TabIndex = 7;
            this.MinSeverity.SelectedIndexChanged += new System.EventHandler(this.MinSeverity_SelectedIndexChanged);
            // 
            // severityBindingSource
            // 
            this.severityBindingSource.DataSource = typeof(HynusWynus_BackupManager.Severity);
            // 
            // DebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(485, 385);
            this.Controls.Add(this.MinSeverity);
            this.Controls.Add(this.OpenDebugLog);
            this.Controls.Add(this.CreateDebugLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SettingsElements);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DebugForm";
            this.Text = "DebugForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.severityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MinimizeWindow;
        private System.Windows.Forms.Button CloseWindow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox SettingsElements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CreateDebugLog;
        private System.Windows.Forms.Button OpenDebugLog;
        private System.Windows.Forms.Timer RefreshRate;
        private System.Windows.Forms.ComboBox MinSeverity;
        private System.Windows.Forms.BindingSource severityBindingSource;
    }
}