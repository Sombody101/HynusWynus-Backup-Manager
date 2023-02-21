using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Utils;

namespace HynusWynus_BackupManager.Forms
{
    public partial class DebugForm : Form
    {
        public DebugForm()
        {
            InitializeComponent();
            CreateDebugLog.Checked = MainWindow.Settings.CreateDebugLog;
            MinSeverity.SelectedIndex = (int)MainWindow.Settings.MinSeverity;
            MinSeverity.Enabled = CreateDebugLog.Checked;

            ErrorHandling.WriteLine("[green]Starting debug console[/]\n");
            RefreshDebug();
        }

        ~DebugForm()
        {
            this.GetClassFields().NullifyFields(this);
            ErrorHandling.WriteExit(this);
        }

        private int appSetHash = MainWindow.AppSettings.GetHashCode();
        private int setHash = MainWindow.Settings.GetHashCode();
        public void RefreshDebug()
        {
            if (appSetHash != MainWindow.AppSettings.GetHashCode() ||
                setHash != MainWindow.Settings.GetHashCode())
                return;

            string[] settings = new string[100];

            int index = 0;

            foreach (var setting in MainWindow.Settings.RetSet())
                settings[index++] = $"{setting.Name}: {setting.GetValue(MainWindow.Settings)}";
            foreach (var setting in MainWindow.AppSettings.RetSet())
                settings[index++] = $"{setting.Name}: {setting.GetValue(MainWindow.AppSettings)}";

            SettingsElements.Lines = settings.Shrink();
            settings = null;
        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            ErrorHandling.WriteLine("[green]Closing debug form[/]");
            MainWindow.AppSettings.DebugFormEnabled = false;
            FindForm().Close();
        }

        private void MinimizeWindow_Click(object sender, EventArgs e)
        {
            FindForm().WindowState = FormWindowState.Minimized;
        }

        // Makes the window draggable
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Shift | Keys.C))
                ErrorHandling.CreateConsole();

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void CreateDebugLog_CheckedChanged(object sender, EventArgs e)
        {
            MainWindow.Settings.CreateDebugLog = CreateDebugLog.Checked;
            MinSeverity.Enabled = CreateDebugLog.Checked;
        }

        private void OpenDebugLog_Click(object sender, EventArgs e)
        {
            if (File.Exists(SettingsAccess.DebugLog))
                Generic.OpenFile(SettingsAccess.DebugLog);
            else
                ErrorHandling.@out("Failed to find debug log. Enable it, then try again.", (Severity)3);
        }

        private void RefreshRate_Tick(object sender, EventArgs e)
        {
            RefreshDebug();
        }

        private void MinSeverity_SelectedIndexChanged(object sender, EventArgs e)
        {
            ErrorHandling.Log($"Minimum log level switched to {(Severity)MinSeverity.SelectedIndex}");
            MainWindow.Settings.MinSeverity = (Severity)MinSeverity.SelectedIndex;
        }
    }
}
