using HynusWynus_BackupManager.Properties;

namespace HynusWynus_BackupManager.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.SettingsMenu = new System.Windows.Forms.Panel();
            this.StartWindowsOnLaunch = new System.Windows.Forms.CheckBox();
            this.SaveAppSettings = new System.Windows.Forms.CheckBox();
            this.SaveOnExit = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CurvePercent = new System.Windows.Forms.NumericUpDown();
            this.Animations = new System.Windows.Forms.CheckBox();
            this.CurveForm = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MinimizeWindow = new System.Windows.Forms.Button();
            this.CloseWindow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SettingsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurvePercent)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingsMenu
            // 
            this.SettingsMenu.AutoScroll = true;
            this.SettingsMenu.AutoScrollMargin = new System.Drawing.Size(0, 100);
            this.SettingsMenu.AutoScrollMinSize = new System.Drawing.Size(0, 100);
            this.SettingsMenu.Controls.Add(this.StartWindowsOnLaunch);
            this.SettingsMenu.Controls.Add(this.SaveAppSettings);
            this.SettingsMenu.Controls.Add(this.SaveOnExit);
            this.SettingsMenu.Controls.Add(this.label3);
            this.SettingsMenu.Controls.Add(this.SaveSettingsButton);
            this.SettingsMenu.Controls.Add(this.label2);
            this.SettingsMenu.Controls.Add(this.CurvePercent);
            this.SettingsMenu.Controls.Add(this.Animations);
            this.SettingsMenu.Controls.Add(this.CurveForm);
            this.SettingsMenu.Controls.Add(this.label1);
            this.SettingsMenu.Location = new System.Drawing.Point(0, 30);
            this.SettingsMenu.Name = "SettingsMenu";
            this.SettingsMenu.Size = new System.Drawing.Size(444, 445);
            this.SettingsMenu.TabIndex = 1;
            // 
            // StartWindowsOnLaunch
            // 
            this.StartWindowsOnLaunch.AutoSize = true;
            this.StartWindowsOnLaunch.Location = new System.Drawing.Point(79, 296);
            this.StartWindowsOnLaunch.Name = "StartWindowsOnLaunch";
            this.StartWindowsOnLaunch.Size = new System.Drawing.Size(231, 23);
            this.StartWindowsOnLaunch.TabIndex = 8;
            this.StartWindowsOnLaunch.Text = "Start Other Windows On Launch";
            this.StartWindowsOnLaunch.UseVisualStyleBackColor = true;
            this.StartWindowsOnLaunch.CheckedChanged += new System.EventHandler(this.StartWindowsOnLaunch_CheckedChanged);
            // 
            // SaveAppSettings
            // 
            this.SaveAppSettings.AutoSize = true;
            this.SaveAppSettings.Location = new System.Drawing.Point(57, 267);
            this.SaveAppSettings.Name = "SaveAppSettings";
            this.SaveAppSettings.Size = new System.Drawing.Size(181, 23);
            this.SaveAppSettings.TabIndex = 7;
            this.SaveAppSettings.Text = "Save Other App Settings";
            this.SaveAppSettings.UseVisualStyleBackColor = true;
            this.SaveAppSettings.CheckedChanged += new System.EventHandler(this.SaveAppSettings_CheckedChanged);
            // 
            // SaveOnExit
            // 
            this.SaveOnExit.AutoSize = true;
            this.SaveOnExit.Checked = true;
            this.SaveOnExit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SaveOnExit.Location = new System.Drawing.Point(57, 238);
            this.SaveOnExit.Name = "SaveOnExit";
            this.SaveOnExit.Size = new System.Drawing.Size(107, 23);
            this.SaveOnExit.TabIndex = 6;
            this.SaveOnExit.Text = "Save On Exit";
            this.SaveOnExit.UseVisualStyleBackColor = true;
            this.SaveOnExit.CheckedChanged += new System.EventHandler(this.SaveOnExit_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "General";
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.SaveSettingsButton.FlatAppearance.BorderSize = 0;
            this.SaveSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveSettingsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveSettingsButton.Location = new System.Drawing.Point(357, 10);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(75, 30);
            this.SaveSettingsButton.TabIndex = 4;
            this.SaveSettingsButton.Text = "Save";
            this.SaveSettingsButton.UseVisualStyleBackColor = false;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Curve Amount";
            // 
            // CurvePercent
            // 
            this.CurvePercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CurvePercent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CurvePercent.Location = new System.Drawing.Point(57, 101);
            this.CurvePercent.Name = "CurvePercent";
            this.CurvePercent.Size = new System.Drawing.Size(52, 26);
            this.CurvePercent.TabIndex = 0;
            this.CurvePercent.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CurvePercent.ValueChanged += new System.EventHandler(this.CurveAmount_ValueChanged);
            // 
            // Animations
            // 
            this.Animations.AutoSize = true;
            this.Animations.Checked = true;
            this.Animations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Animations.Location = new System.Drawing.Point(57, 133);
            this.Animations.Name = "Animations";
            this.Animations.Size = new System.Drawing.Size(100, 23);
            this.Animations.TabIndex = 2;
            this.Animations.Text = "Animations";
            this.Animations.UseVisualStyleBackColor = true;
            this.Animations.CheckedChanged += new System.EventHandler(this.EnableAnimations_CheckedChanged);
            // 
            // CurveForm
            // 
            this.CurveForm.AutoSize = true;
            this.CurveForm.Checked = true;
            this.CurveForm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CurveForm.Location = new System.Drawing.Point(57, 72);
            this.CurveForm.Name = "CurveForm";
            this.CurveForm.Size = new System.Drawing.Size(278, 23);
            this.CurveForm.TabIndex = 1;
            this.CurveForm.Text = "Enable Window Curve (Restart Required)";
            this.CurveForm.UseVisualStyleBackColor = true;
            this.CurveForm.CheckedChanged += new System.EventHandler(this.EnableWindowCurve_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visual Elements";
            // 
            // MinimizeWindow
            // 
            this.MinimizeWindow.FlatAppearance.BorderSize = 0;
            this.MinimizeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeWindow.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeWindow.ForeColor = System.Drawing.SystemColors.Control;
            this.MinimizeWindow.Location = new System.Drawing.Point(367, -6);
            this.MinimizeWindow.Name = "MinimizeWindow";
            this.MinimizeWindow.Size = new System.Drawing.Size(40, 38);
            this.MinimizeWindow.TabIndex = 6;
            this.MinimizeWindow.Text = "−";
            this.MinimizeWindow.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MinimizeWindow.UseVisualStyleBackColor = true;
            this.MinimizeWindow.Click += new System.EventHandler(this.MinimizeWindow_Click);
            // 
            // CloseWindow
            // 
            this.CloseWindow.FlatAppearance.BorderSize = 0;
            this.CloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseWindow.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseWindow.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseWindow.Location = new System.Drawing.Point(407, -8);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(50, 40);
            this.CloseWindow.TabIndex = 5;
            this.CloseWindow.Text = "X";
            this.CloseWindow.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.CloseWindow.UseVisualStyleBackColor = true;
            this.CloseWindow.Click += new System.EventHandler(this.CloseWindow_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.MinimizeWindow);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.CloseWindow);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 30);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragMouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragMouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(155, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 370);
            this.panel2.TabIndex = 2;
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
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragMouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragMouseUp);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(445, 475);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SettingsMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.SettingsMenu.ResumeLayout(false);
            this.SettingsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CurvePercent)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SettingsMenu;
        private System.Windows.Forms.CheckBox SaveOnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveSettingsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown CurvePercent;
        private System.Windows.Forms.CheckBox Animations;
        private System.Windows.Forms.CheckBox CurveForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MinimizeWindow;
        private System.Windows.Forms.Button CloseWindow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox SaveAppSettings;
        private System.Windows.Forms.CheckBox StartWindowsOnLaunch;
    }
}