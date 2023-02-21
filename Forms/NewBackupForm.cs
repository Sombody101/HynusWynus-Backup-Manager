using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace HynusWynus_BackupManager.Forms
{
    public partial class NewBackupForm : Form
    {
        public NewBackupForm()
        {
            InitializeComponent();

            ErrorHandling.WriteLine("[green]Starting backup creation form[/]");
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

        private void CloseWindow_Click(object sender, System.EventArgs e)
        {
            MainWindow.AppSettings.NewBackupFormEnabled = false;
            FindForm().Close();
        }

        private void MinimizeWindow_Click(object sender, System.EventArgs e)
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
    }
}
