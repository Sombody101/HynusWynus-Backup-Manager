using Spectre.Console;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace HynusWynus_BackupManager
{
    // Im just using this class for everything since its static
    public static class ErrorHandling
    {
        // Mainly for this class to access controls from MainWindow, but is also being used to
        // statically access MainWindow
        public static MainWindow T;

        public static void InvalidateEverything()
        {
            T.Invalidate();
            MainWindow.SettingsForm.Invalidate();

            foreach (var item in T.GetType().GetFields())
                if (item.GetType() == typeof(Form))
                    ((Form)item.GetValue(T)).Invalidate();
        }

        public static void InitForm<T>(ref T form) where T : Form, new()
        {
            form = new T();
            form.Show();
            Log($"Form {form.GetType()} initialized");
        }

        public static async Task ShowResult(string _message, byte _result, int _ms = 5000, Exception ex = null, bool @override = false, bool OVERRIDE_OUTPUT_BUFFER = false)
        {
            if (_result is 2)
                T.ResultImage.Image = Resources.Warning;
            else if (_result is 3)
                T.ResultImage.Image = Resources.Error;
            else
                T.ResultImage.Image = Resources.Success;

            T.ResultBox.Text = _message;
            if (ex != null)
                WriteEx(ex);
            WriteLine(_message, _result, OVERRIDE_OUTPUT_BUFFER);

            if (!@override || !(_result is 3))
            {
                await Task.Delay(_ms);
                T.ResultImage.Image = null;
                T.ResultBox.Text = "";
            }
        }

        public static void @out(Exception ex, Severity result = Severity.Warning, int ms = 5000)
        {
            _ = ShowResult(ex.Message, (byte)result, ms);
        }

        public static void @out(string message, Severity result = Severity.Info, int ms = 5000, bool @override = false, bool OVERRIDE_OUTPUT_BUFFER = false)
        {
            _ = ShowResult(message, (byte)result, ms, OVERRIDE_OUTPUT_BUFFER: OVERRIDE_OUTPUT_BUFFER);
        }

        public static void @out(string message, Exception ex, Severity result = Severity.Info, int ms = 5000, bool @override = false, bool OVERRIDE_OUTPUT_BUFFER = false)
        {
            _ = ShowResult(message, (byte)result, ms, ex, @override, OVERRIDE_OUTPUT_BUFFER);
        }

        public static void holdout(string message, Severity result = Severity.Info)
        {
            _ = ShowResult(message, (byte)result, @override: true);
        }

        public static List<string> OutputBuffer = new List<string>();
        public static List<Exception> ExceptionBuffer = new List<Exception>();
        [DllImport("kernel32")]
        static extern bool AllocConsole();
        public static void CreateConsole()
        {
            Log($"Staring AllocConsole : {Generic.GetStackTrace()}");

            AllocConsole();
            MainWindow.AppSettings.ConsoleEnabled = true;

            AnsiConsole.MarkupLine("[green]Console starting[/]\n");

            if (OutputBuffer.Count != 0)
            {
                AnsiConsole.MarkupLine("[yellow]* OUTPUT BUFFER *[/]");
                foreach (var @out in OutputBuffer)
                    AnsiConsole.MarkupLine(@out);
                OutputBuffer.Clear();
                AnsiConsole.MarkupLine("[yellow]* OUTPUT BUFFER CLEARED *[/]");
            }
            if (ExceptionBuffer.Count != 0)
            {
                AnsiConsole.MarkupLine("[yellow]* EXCEPTION BUFFER *[/]");
                foreach (var @out in ExceptionBuffer)
                    AnsiConsole.WriteException(@out);
                ExceptionBuffer.Clear();
                AnsiConsole.MarkupLine("[yellow]* EXCEPTION BUFFER CLEARED *[/]");
            }
            AnsiConsole.MarkupLine("\n[red]WARNING: Closing this console will also close the main application[/]");
        }

        public static void Write(string message, bool OVERRIDE_OUTPUT_BUFFER = false, byte severity = 0)
        {
            if (!OVERRIDE_OUTPUT_BUFFER)
            {
                if (!MainWindow.AppSettings.ConsoleEnabled)
                    OutputBuffer.Add(message);
                else
                    AnsiConsole.Markup(message);
            }
            else
            {
                if (MainWindow.AppSettings.ConsoleEnabled)
                    AnsiConsole.Markup(message);
            }
            Log(message.Replace("\n", ""), severity);
        }

        public static void WriteEx(Exception ex)
        {
            if (MainWindow.AppSettings.ConsoleEnabled)
                AnsiConsole.WriteException(ex);
            else
                ExceptionBuffer.Add(ex);
        }

        public static void WriteLine(string message, byte severity = 0, bool OVERRIDE_OUTPUT_BUFFER = false)
        {
            Write(message + "\n", OVERRIDE_OUTPUT_BUFFER, severity);
        }

        public static void WriteExit<T>(T closingObj)
        {
            WriteLine($"[lightgreen]{typeof(T)}[/] {(MainWindow.AppSettings.IsClosing ? "finalizing" : "exiting")} : Hash => [yellow]{closingObj.GetHashCode()}[/]");
        }

        public static void Log(string message, byte severity)
        {
            if (severity < (byte)MainWindow.Settings.MinSeverity)
                return;

            if (MainWindow.Settings.CreateDebugLog)
                File.AppendAllText(SettingsAccess.DebugLog, $"[{DateTime.Now}] " +
                    $"{(severity is 1 ? "INFO " : (severity is 2 ? "WARN " : (severity is 3 ? "ERROR" : "LOG  ")))}: " +
                    $"{Markup.Remove(message)}\n");
        }

        public static void Log(string message, Severity severity = Severity.Log)
        {
            if ((byte)severity < (byte)MainWindow.Settings.MinSeverity)
                return;

            if (MainWindow.Settings.CreateDebugLog)
                File.AppendAllText(SettingsAccess.DebugLog, $"[{DateTime.Now}] " +
                    $"{(severity is Severity.Info ? "INFO " : (severity is Severity.Warning ? "WARN " : (severity is Severity.Error ? "ERROR" : "LOG  ")))}: " +
                    $"{Markup.Remove(message)}\n");
        }
    }

    public enum Severity : byte
    {
        Log = 0,
        Info = 1,
        Warning = 2,
        Error = 3,
    }
}
