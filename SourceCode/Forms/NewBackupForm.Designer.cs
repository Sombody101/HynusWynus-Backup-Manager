namespace HynusWynus_BackupManager.Forms
{
    partial class NewBackupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewBackupForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.MinimizeWindow = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.CloseWindow = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 370);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel4.Controls.Add(this.MinimizeWindow);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.CloseWindow);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(630, 30);
            this.panel4.TabIndex = 1;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragMouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragMouseUp);
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
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Location = new System.Drawing.Point(155, 30);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(475, 370);
            this.panel6.TabIndex = 2;
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
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragMouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragMouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragMouseUp);
            // 
            // NewBackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(630, 400);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewBackupForm";
            this.Text = "Backup Creator";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button MinimizeWindow;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button CloseWindow;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}