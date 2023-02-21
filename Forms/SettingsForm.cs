using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HynusWynus_BackupManager.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            CurvePercent.Value = MainWindow.Settings.CurvePercent;
            CurveForm.Checked = MainWindow.Settings.CurveForm;
            Animations.Checked = MainWindow.Settings.Animations;
            SaveOnExit.Checked = MainWindow.Settings.SaveOnExit;
            SaveAppSettings.Checked = MainWindow.Settings.SaveAppSettings;
            StartWindowsOnLaunch.Checked = MainWindow.Settings.StartWindowsOnLaunch;
            StartWindowsOnLaunch.Enabled = SaveAppSettings.Checked;

            ErrorHandling.WriteLine("[green]Starting settings form[/]");
        }

        // Makes the windows edges round
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            if (MainWindow.Settings.CurveForm)
                using (var path = new GraphicsPath())
                {
                    path.AddArc(0, 0, MainWindow.Settings.CurvePercent, MainWindow.Settings.CurvePercent, 180, 90);
                    path.AddArc(ClientRectangle.Width - MainWindow.Settings.CurvePercent, 0,
                        MainWindow.Settings.CurvePercent,
                        MainWindow.Settings.CurvePercent, 270, 90);
                    path.AddArc(ClientRectangle.Width - MainWindow.Settings.CurvePercent,
                        ClientRectangle.Height - MainWindow.Settings.CurvePercent,
                        MainWindow.Settings.CurvePercent, MainWindow.Settings.CurvePercent, 0, 90);
                    path.AddArc(0, ClientRectangle.Height - MainWindow.Settings.CurvePercent,
                        MainWindow.Settings.CurvePercent, MainWindow.Settings.CurvePercent, 90, 90);
                    path.CloseFigure();
                    Region = new Region(path);
                }
            base.OnPaint(e);
        }

        // Close/Minimize window
        private void CloseWindow_Click(object sender, EventArgs e)
        {
            FindForm().Close();
            MainWindow.AppSettings.SettingsFormEnabled = false;
        }

        private void MinimizeWindow_Click(object sender, EventArgs e)
        {
            FindForm().WindowState = FormWindowState.Minimized;
        }

        // Makes window draggable
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        private void DragMouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursor = Cursor.Position;
            lastForm = Location;
        }

        private void DragMouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentCursor = Cursor.Position;
                Location = new Point(lastForm.X + (currentCursor.X - lastCursor.X),
                    lastForm.Y + (currentCursor.Y - lastCursor.Y));
            }
        }

        private void DragMouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        // Actual settings elements
        private void EnableWindowCurve_CheckedChanged(object sender, EventArgs e)
        {
            MainWindow.Settings.CurveForm = CurveForm.Checked;
            if (MainWindow.Settings.CurveForm && MainWindow.Settings.CurvePercent is 0)
            {
                MainWindow.Settings.CurvePercent = 1;
                CurvePercent.Value = 1;
            }

            MainWindow.ChangesMade = true;
            ErrorHandling.InvalidateEverything();
        }

        private void CurveAmount_ValueChanged(object sender, EventArgs e)
        {
            if (CurvePercent.Value is 0)
                CurveForm.Checked = false;
            MainWindow.Settings.CurvePercent = (int)CurvePercent.Value;
            MainWindow.ChangesMade = true;
            ErrorHandling.InvalidateEverything();
        }

        private void EnableAnimations_CheckedChanged(object sender, EventArgs e)
        {
            MainWindow.Settings.Animations = Animations.Checked;
            MainWindow.ChangesMade = true;
        }

        private void SaveOnExit_CheckedChanged(object sender, EventArgs e)
        {
            MainWindow.Settings.SaveOnExit = SaveOnExit.Checked;
        }

        private bool save_deb = false;
        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            if (save_deb)
                return;
            save_deb = true;

            ErrorHandling.@out("Saving...", (Severity)2, @override: true);

            try
            {
                MainWindow.Settings.SetSettings();
                MainWindow.AppSettings.SetAppSettings();
            }
            catch (Exception ex)
            {
                ErrorHandling.@out("Failed to save settings", ex, (Severity)3);
                save_deb = false;
                return;
            }

            ErrorHandling.@out("Settings saved");
            MainWindow.ChangesMade = false;
            save_deb = false;
        }

        private void SaveAppSettings_CheckedChanged(object sender, EventArgs e)
        {
            MainWindow.Settings.SaveAppSettings = SaveAppSettings.Checked;
            StartWindowsOnLaunch.Enabled = SaveAppSettings.Checked;
        }

        private void StartWindowsOnLaunch_CheckedChanged(object sender, EventArgs e)
        {
            MainWindow.Settings.StartWindowsOnLaunch = StartWindowsOnLaunch.Checked;
        }
    }
}
