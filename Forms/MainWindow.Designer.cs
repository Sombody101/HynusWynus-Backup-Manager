namespace HynusWynus_BackupManager
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
                components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ResultBox = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MinimizeWindow = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseWindow = new System.Windows.Forms.Button();
            this.SideMenu = new System.Windows.Forms.Panel();
            this.HiddenUnsavedLabel = new System.Windows.Forms.Label();
            this.UnsavedLabel = new System.Windows.Forms.Label();
            this.SettingsMenuButton = new System.Windows.Forms.Button();
            this.DeviceName = new System.Windows.Forms.Label();
            this.MinimizeSideWindow = new System.Windows.Forms.Button();
            this.AnimationTiming = new System.Windows.Forms.Timer(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.EditBackup = new System.Windows.Forms.Button();
            this.NewBackup = new System.Windows.Forms.Button();
            this.BackupsView = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.SettingsImage = new System.Windows.Forms.PictureBox();
            this.ResultImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.SideMenu.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.ResultImage);
            this.panel1.Controls.Add(this.ResultBox);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.MinimizeWindow);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.CloseWindow);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 30);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragMouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragMouseUp);
            // 
            // ResultBox
            // 
            this.ResultBox.AutoSize = true;
            this.ResultBox.Location = new System.Drawing.Point(76, 9);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(102, 19);
            this.ResultBox.TabIndex = 7;
            this.ResultBox.Text = "PLACEHOLDER";
            this.ResultBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMouseDown);
            this.ResultBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragMouseMove);
            this.ResultBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragMouseUp);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(155, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(472, 358);
            this.panel3.TabIndex = 2;
            // 
            // MinimizeWindow
            // 
            this.MinimizeWindow.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MinimizeWindow.FlatAppearance.BorderSize = 0;
            this.MinimizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeWindow.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeWindow.ForeColor = System.Drawing.SystemColors.Control;
            this.MinimizeWindow.Location = new System.Drawing.Point(550, -8);
            this.MinimizeWindow.Name = "MinimizeWindow";
            this.MinimizeWindow.Size = new System.Drawing.Size(40, 38);
            this.MinimizeWindow.TabIndex = 6;
            this.MinimizeWindow.Text = "−";
            this.MinimizeWindow.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MinimizeWindow.UseVisualStyleBackColor = true;
            this.MinimizeWindow.Click += new System.EventHandler(this.MinimizeWindow_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(155, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 370);
            this.panel2.TabIndex = 2;
            // 
            // CloseWindow
            // 
            this.CloseWindow.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CloseWindow.FlatAppearance.BorderSize = 0;
            this.CloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseWindow.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseWindow.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseWindow.Location = new System.Drawing.Point(590, -10);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(50, 40);
            this.CloseWindow.TabIndex = 5;
            this.CloseWindow.Text = "X";
            this.CloseWindow.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.CloseWindow.UseVisualStyleBackColor = true;
            this.CloseWindow.Click += new System.EventHandler(this.CloseWindow_Click);
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SideMenu.Controls.Add(this.HiddenUnsavedLabel);
            this.SideMenu.Controls.Add(this.UnsavedLabel);
            this.SideMenu.Controls.Add(this.SettingsImage);
            this.SideMenu.Controls.Add(this.SettingsMenuButton);
            this.SideMenu.Controls.Add(this.DeviceName);
            this.SideMenu.Controls.Add(this.MinimizeSideWindow);
            this.SideMenu.Location = new System.Drawing.Point(0, 30);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(155, 370);
            this.SideMenu.TabIndex = 1;
            // 
            // HiddenUnsavedLabel
            // 
            this.HiddenUnsavedLabel.AutoSize = true;
            this.HiddenUnsavedLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HiddenUnsavedLabel.Location = new System.Drawing.Point(23, 351);
            this.HiddenUnsavedLabel.Name = "HiddenUnsavedLabel";
            this.HiddenUnsavedLabel.Size = new System.Drawing.Size(200, 38);
            this.HiddenUnsavedLabel.TabIndex = 13;
            this.HiddenUnsavedLabel.Text = "PLACEHOLDER";
            // 
            // UnsavedLabel
            // 
            this.UnsavedLabel.AutoSize = true;
            this.UnsavedLabel.Location = new System.Drawing.Point(39, 351);
            this.UnsavedLabel.Name = "UnsavedLabel";
            this.UnsavedLabel.Size = new System.Drawing.Size(102, 19);
            this.UnsavedLabel.TabIndex = 5;
            this.UnsavedLabel.Text = "PLACEHOLDER";
            // 
            // SettingsMenuButton
            // 
            this.SettingsMenuButton.FlatAppearance.BorderSize = 0;
            this.SettingsMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsMenuButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsMenuButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SettingsMenuButton.Location = new System.Drawing.Point(0, 310);
            this.SettingsMenuButton.Name = "SettingsMenuButton";
            this.SettingsMenuButton.Size = new System.Drawing.Size(155, 40);
            this.SettingsMenuButton.TabIndex = 9;
            this.SettingsMenuButton.Text = "Settings";
            this.SettingsMenuButton.UseVisualStyleBackColor = true;
            this.SettingsMenuButton.Click += new System.EventHandler(this.SettingsMenuButton_Click);
            this.SettingsMenuButton.MouseEnter += new System.EventHandler(this.SettingsImage_MouseEnter);
            this.SettingsMenuButton.MouseLeave += new System.EventHandler(this.SettingsImage_MouseLeave);
            // 
            // DeviceName
            // 
            this.DeviceName.AutoSize = true;
            this.DeviceName.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeviceName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeviceName.Location = new System.Drawing.Point(40, 13);
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.Size = new System.Drawing.Size(118, 17);
            this.DeviceName.TabIndex = 8;
            this.DeviceName.Text = "NO_DEV_NAME";
            this.DeviceName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinimizeSideWindow
            // 
            this.MinimizeSideWindow.FlatAppearance.BorderSize = 0;
            this.MinimizeSideWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeSideWindow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeSideWindow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MinimizeSideWindow.Location = new System.Drawing.Point(0, 0);
            this.MinimizeSideWindow.Name = "MinimizeSideWindow";
            this.MinimizeSideWindow.Size = new System.Drawing.Size(40, 40);
            this.MinimizeSideWindow.TabIndex = 7;
            this.MinimizeSideWindow.Text = "☰";
            this.MinimizeSideWindow.UseVisualStyleBackColor = true;
            this.MinimizeSideWindow.Click += new System.EventHandler(this.MinimizeSideWindow_Click);
            // 
            // AnimationTiming
            // 
            this.AnimationTiming.Interval = 25;
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.Controls.Add(this.EditBackup);
            this.MainPanel.Controls.Add(this.NewBackup);
            this.MainPanel.Controls.Add(this.BackupsView);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Location = new System.Drawing.Point(155, 30);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(470, 365);
            this.MainPanel.TabIndex = 2;
            // 
            // EditBackup
            // 
            this.EditBackup.FlatAppearance.BorderSize = 0;
            this.EditBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBackup.Location = new System.Drawing.Point(225, 11);
            this.EditBackup.Name = "EditBackup";
            this.EditBackup.Size = new System.Drawing.Size(101, 25);
            this.EditBackup.TabIndex = 4;
            this.EditBackup.Text = "Edit Backup";
            this.EditBackup.UseVisualStyleBackColor = true;
            // 
            // NewBackup
            // 
            this.NewBackup.FlatAppearance.BorderSize = 0;
            this.NewBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewBackup.Location = new System.Drawing.Point(332, 11);
            this.NewBackup.Name = "NewBackup";
            this.NewBackup.Size = new System.Drawing.Size(101, 25);
            this.NewBackup.TabIndex = 3;
            this.NewBackup.Text = "New Backup";
            this.NewBackup.UseVisualStyleBackColor = true;
            this.NewBackup.Click += new System.EventHandler(this.NewBackup_Click);
            // 
            // BackupsView
            // 
            this.BackupsView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.BackupsView.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackupsView.Location = new System.Drawing.Point(45, 45);
            this.BackupsView.Name = "BackupsView";
            this.BackupsView.Size = new System.Drawing.Size(385, 280);
            this.BackupsView.TabIndex = 2;
            this.BackupsView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.BackupsView_AfterLabelEdit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Active Backups";
            // 
            // SettingsImage
            // 
            this.SettingsImage.BackColor = System.Drawing.Color.Transparent;
            this.SettingsImage.Image = ((System.Drawing.Image)(resources.GetObject("SettingsImage.Image")));
            this.SettingsImage.Location = new System.Drawing.Point(0, 310);
            this.SettingsImage.Name = "SettingsImage";
            this.SettingsImage.Size = new System.Drawing.Size(40, 40);
            this.SettingsImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SettingsImage.TabIndex = 10;
            this.SettingsImage.TabStop = false;
            this.SettingsImage.Click += new System.EventHandler(this.SettingsMenuButton_Click);
            this.SettingsImage.MouseEnter += new System.EventHandler(this.SettingsImage_MouseEnter);
            this.SettingsImage.MouseLeave += new System.EventHandler(this.SettingsImage_MouseLeave);
            // 
            // ResultImage
            // 
            this.ResultImage.Location = new System.Drawing.Point(52, 6);
            this.ResultImage.Name = "ResultImage";
            this.ResultImage.Size = new System.Drawing.Size(20, 20);
            this.ResultImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ResultImage.TabIndex = 8;
            this.ResultImage.TabStop = false;
            this.ResultImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMouseDown);
            this.ResultImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragMouseMove);
            this.ResultImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragMouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(630, 400);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SideMenu);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "HynusWynus Backup Manager";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SideMenu.ResumeLayout(false);
            this.SideMenu.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CloseWindow;
        private System.Windows.Forms.Button MinimizeWindow;
        private System.Windows.Forms.Panel SideMenu;
        private System.Windows.Forms.Button MinimizeSideWindow;
        private System.Windows.Forms.Timer AnimationTiming;
        private System.Windows.Forms.Label DeviceName;
        private System.Windows.Forms.Button SettingsMenuButton;
        private System.Windows.Forms.PictureBox SettingsImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel MainPanel;
        public System.Windows.Forms.PictureBox ResultImage;
        public System.Windows.Forms.Label ResultBox;
        private System.Windows.Forms.Label UnsavedLabel;
        private System.Windows.Forms.Label HiddenUnsavedLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView BackupsView;
        private System.Windows.Forms.Button EditBackup;
        private System.Windows.Forms.Button NewBackup;
    }
}

