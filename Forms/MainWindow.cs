using HynusWynus_BackupManager.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using Utils;

namespace HynusWynus_BackupManager
{
    // For SVGs: https://www.svgrepo.com/ (SVGs wont work here)
    // Other Icons: https://iconer.app/
    public partial class MainWindow : Form
    {
        // Looks
        public readonly Color Hover = Color.FromArgb(45, 45, 45);
        public readonly Color Exit = Color.Transparent;
        public readonly Color OnClick = Color.FromArgb(80, 80, 80);

        // Backups
        public static List<Backup> Backups;

        // Forms
        public static DebugForm DebugForm;
        public static SettingsForm SettingsForm;
        public static NewBackupForm NewBackupForm;

        // Classes
        public static Settings Settings;
        public static AppSettings AppSettings;

        // Random variables
        public bool _appLoaded = false;

        public MainWindow()
        {
            InitializeComponent();

            ResultBox.Text = "";
            UnsavedLabel.Text = "";
            HiddenUnsavedLabel.Text = "";

            Settings = new Settings();
            AppSettings = new AppSettings();
            ErrorHandling.WriteLine("[green]App starting...[/]");

            DeviceName.Text = Environment.MachineName.Length > 13 ?
                Environment.MachineName.Substring(0, 10) + "..." :
                Environment.MachineName;

            ErrorHandling.T = this;
            try
            {
                Settings = Settings.GetSettings();
                AppSettings.SettingsLoaded = true;

                if (!Settings.IsOpen)
                {
                    SideMenu.Width = 40;
                    MainPanel.Location = new Point(MainPanel.Location.X - 115, MainPanel.Location.Y);
                }

                if (Settings.SaveAppSettings)
                {
                    AppSettings = AppSettings.GetAppSettings();
                    if (Settings.StartWindowsOnLaunch)
                    {
                        if (AppSettings.NewBackupFormEnabled)
                            ErrorHandling.InitForm(ref NewBackupForm);

                        if (AppSettings.ConsoleEnabled)
                            ErrorHandling.CreateConsole();

                        if (AppSettings.DebugFormEnabled)
                            ErrorHandling.InitForm(ref DebugForm);

                        if (AppSettings.SettingsFormEnabled)
                            ErrorHandling.InitForm(ref SettingsForm);
                    }
                }

                ErrorHandling.@out("Settings loaded successfully");
                ChangesMade = AppSettings.ChangesMade = false;
            }
            catch (IOException) { ErrorHandling.@out("Could not find settings file, creating one", (Severity)2); Settings = new Settings(); Settings.SetSettings(); }
            catch (JsonReaderException) { ErrorHandling.@out("Settings file is not in JSON format. Either fix the issue, or delete the file", (Severity)3); }
            catch (Exception ex) { ErrorHandling.@out(ex, (Severity)3); };
            _appLoaded = true;

            AppDomain.CurrentDomain.ProcessExit += (e, x) =>
            {
                ErrorHandling.Log("App exit triggered");
                AppSettings.IsClosing = true;
                if (Settings.SaveOnExit)
                {
                    Settings.SetSettings();
                    if (Settings.SaveAppSettings)
                        AppSettings.SetAppSettings();
                }
                ErrorHandling.WriteLine("App exiting...");
            };

            try
            {
                Backups = Backups.GetBackups();
            }
            catch
            {
                ErrorHandling.@out("Could not load backups. If this is your first time, press 'New Backup' to get started", Severity.Warning, 10000);
                Backups = new List<Backup>();
            }

            if (Backups.Count != 0)
                foreach (Backup backup in Backups)
                {
                    TreeNode backupNode = new TreeNode(backup.Name);

                    backupNode.Nodes.Add(new TreeNode("Directory Path: " + backup.DirectoryPath));
                    backupNode.Nodes.Add(new TreeNode("Date: " + backup.Date.ToShortDateString()));
                    backupNode.Nodes.Add(new TreeNode("Size: " + backup.Size.ToString()));
                    backupNode.Nodes.Add(new TreeNode("Compression Type: " + backup.CompressionType));

                    BackupsView.Nodes.Add(backupNode);
                }
            else
                BackupsView.Nodes.Add(new TreeNode("No backups available"));
        }

        ~MainWindow()
        {
            this.GetClassFields().NullifyFields(this);
            ErrorHandling.WriteExit(this);
        }

        private void MainWindow_Load(object sender, EventArgs e) { }

        // Makes the windows edges round
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            if (Settings.CurveForm)
                using (var path = new GraphicsPath())
                {
                    path.AddArc(0, 0, Settings.CurvePercent, Settings.CurvePercent, 180, 90);
                    path.AddArc(ClientRectangle.Width - Settings.CurvePercent, 0, Settings.CurvePercent, Settings.CurvePercent, 270, 90);
                    path.AddArc(ClientRectangle.Width - Settings.CurvePercent,
                        ClientRectangle.Height - Settings.CurvePercent, Settings.CurvePercent, Settings.CurvePercent, 0, 90);
                    path.AddArc(0, ClientRectangle.Height - Settings.CurvePercent, Settings.CurvePercent, Settings.CurvePercent, 90, 90);
                    path.CloseFigure();
                    Region = new Region(path);
                }
            base.OnPaint(e);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Shift | Keys.D))
            {
                if (!AppSettings.DebugFormEnabled)
                {
                    DebugForm = new DebugForm();
                    DebugForm.Show();
                    AppSettings.DebugFormEnabled = true;
                }
                else
                    ErrorHandling.@out("Debug console already open", (Severity)2);
            }
            else if (keyData == (Keys.Control | Keys.Shift | Keys.C))
            {
                if (!AppSettings.ConsoleEnabled)
                    ErrorHandling.CreateConsole();
                else
                    ErrorHandling.@out("Debug console already open", (Severity)2);
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        // Makes the window draggable since there is no window frame
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

        // Control buttons (Exit, Minimize/SideWindow)
        private void MinimizeWindow_Click(object sender, EventArgs e)
        {
            FindForm().WindowState = FormWindowState.Minimized;
        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Provides the animation for the side menu
        private void StartAnim(int targetWidth, int widthStep, ref Panel panel)
        {
            if (!deb2)
                return;
            int w = panel.Width;
            Panel tempPanel = panel;
            Timer AnimationTime = new Timer { Interval = 1 };
            AnimationTime.Tick += (sender, e) =>
            {
                if (w > targetWidth)
                {
                    w -= widthStep;
                    if (w / 8 > tempPanel.Width && widthStep != 0)
                        widthStep--;

                    tempPanel.Width = w;
                }
                else if (w < targetWidth)
                {
                    w += widthStep;
                    if (w * 8 < tempPanel.Width && widthStep != 0)
                        widthStep--;
                    tempPanel.Width = w;
                }
                else
                {
                    AnimationTiming.Stop();
                    deb2 = true;
                    AnimationTime.Dispose();
                    tempPanel.Width = targetWidth;
                }
            };
            AnimationTime.Start();
        }

        private void StartSlide(int targetW, int widthStep, ref Panel panel)
        {
            if (!deb1)
                return;
            int w = panel.Location.X;
            Panel tempPanel = panel;
            Timer SlideTime = new Timer { Interval = 1 };
            SlideTime.Tick += (sender, e) =>
            {
                if (w > targetW)
                {
                    w -= widthStep;
                    if (w / 8 > tempPanel.Location.X && widthStep != 0)
                        widthStep--;
                    tempPanel.Location = new Point(w, tempPanel.Location.Y);
                }
                else if (w < targetW)
                {
                    w += widthStep;
                    if (w * 8 < tempPanel.Location.X && widthStep != 0)
                        widthStep--;
                    tempPanel.Location = new Point(w, tempPanel.Location.Y);
                }
                else
                {
                    AnimationTiming.Stop();
                    deb1 = true;
                    SlideTime.Dispose();
                }
            };
            SlideTime.Start();
        }

        private bool deb1 = true;
        private bool deb2 = true;
        private void MinimizeSideWindow_Click(object sender, EventArgs e)
        {
            if (deb1 && deb2)
            {
                if (!Settings.IsOpen)
                    HiddenUnsavedLabel.Text = "";

                if (Settings.IsOpen)
                {
                    if (Settings.Animations)
                    {
                        StartAnim(40, 5, ref SideMenu);
                        StartSlide(MainPanel.Location.X - 115, 5, ref MainPanel);
                    }
                    else
                    {
                        SideMenu.Width = 40;
                        MainPanel.Location = new Point(MainPanel.Location.X - 115, MainPanel.Location.Y);
                    }
                }
                else
                {
                    if (Settings.Animations)
                    {
                        StartAnim(155, 5, ref SideMenu);
                        StartSlide(MainPanel.Location.X + 115, 5, ref MainPanel);
                    }
                    else
                    {
                        SideMenu.Width = 155;
                        MainPanel.Location = new Point(MainPanel.Location.X + 115, MainPanel.Location.Y);
                    }
                }

                if (Settings.IsOpen && ChangesMade)
                    HiddenUnsavedLabel.Text = "*";

                if (Settings.Animations)
                    deb1 = deb2 = false;
                Settings.IsOpen = !Settings.IsOpen;
            }
        }

        // The TreeView for the List<Backup>
        private void BackupsView_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label != null)
            {
                // Get the backup object associated with the edited node
                Backup backup = (Backup)e.Node.Tag;

                // Update the backup name
                backup.Name = e.Label;

                // Update the node text to reflect the new name
                e.Node.Text = backup.Name;
            }
        }

        // Makes the images match the same color as the menu buttons (I still need to make clicks match)
        private void SettingsImage_MouseEnter(object sender, EventArgs e)
        {
            SettingsMenuButton.BackColor = SettingsImage.BackColor = Hover;
            SettingsMenuButton.FlatAppearance.MouseOverBackColor = Hover;
        }

        private void SettingsImage_MouseLeave(object sender, EventArgs e)
        {
            SettingsMenuButton.BackColor = SettingsImage.BackColor = Exit;
            SettingsMenuButton.FlatAppearance.MouseOverBackColor = Exit;
        }

        // Side menu on click

        private void SettingsMenuButton_Click(object sender, EventArgs e)
        {
            if (AppSettings.SettingsFormEnabled)
                return;
            ErrorHandling.InitForm(ref SettingsForm);
            AppSettings.SettingsFormEnabled = true;
        }

        // Settings menu
        public static bool ChangesMade
        {
            get => AppSettings.ChangesMade;
            set
            {
                if (!ErrorHandling.T._appLoaded)
                {
                    AppSettings.ChangesMade = value;
                    return;
                }

                if (value is true)
                    ErrorHandling.T.UnsavedLabel.Text = "UNSAVED SETTINGS";
                else
                    ErrorHandling.T.UnsavedLabel.Text = "";

                if (!Settings.IsOpen)
                {
                    if (value is true)
                        ErrorHandling.T.HiddenUnsavedLabel.Text = "*";
                    else
                        ErrorHandling.T.HiddenUnsavedLabel.Text = "";
                }
                AppSettings.ChangesMade = value;
            }
        }

        // Other buttons
        private void NewBackup_Click(object sender, EventArgs e)
        {
            if (AppSettings.NewBackupFormEnabled)
                return;
            ErrorHandling.InitForm(ref NewBackupForm);
            AppSettings.NewBackupFormEnabled = true;
        }
    }
}
