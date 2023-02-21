using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Documents;
using Utils;

namespace HynusWynus_BackupManager
{
    public static class SettingsAccess
    {
        public static readonly string Assets = AppDomain.CurrentDomain.BaseDirectory + "Assets\\";
        public static readonly string SettingsPath = Assets + "settings.json";
        public static readonly string AppSettingsPath = Assets + "appsettings.json";
        public static readonly string DebugLog = Assets.Replace("Assets\\", "HynusWynusDebugLog.log");
        public static readonly string BackupList = Assets + "BackupsList.json";

        private static void DirCheck()
        {
            if (!Directory.Exists(Assets))
                Directory.CreateDirectory(Assets);
        }

        public static void SetSettings(this Settings sets)
        {
            DirCheck();
            File.WriteAllText(SettingsPath, JsonConvert.SerializeObject(sets));
        }

        public static Settings GetSettings(this Settings s)
        {
            if (!File.Exists(SettingsPath))
                throw new IOException($"Failed to find Settings : {SettingsPath}");
            var T = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(SettingsPath));
            if (T is null)
                throw new Exception("Settings returned null");
            return T;
        }

        public static AppSettings GetAppSettings(this AppSettings s)
        {
            if (!File.Exists(AppSettingsPath))
                throw new IOException($"Failed to find AppSettings : {AppSettingsPath}");
            var T = JsonConvert.DeserializeObject<AppSettings>(File.ReadAllText(AppSettingsPath));
            if (T is null)
                throw new Exception("AppSettings returned null");
            return T;
        }

        public static void SetAppSettings(this AppSettings s)
        {
            DirCheck();
            File.WriteAllText(AppSettingsPath, JsonConvert.SerializeObject(s));
        }

        public static List<Backup> GetBackups(this List<Backup> s)
        {
            DirCheck();
            if (!File.Exists(BackupList))
                throw new IOException($"Failed to find BackupList : {BackupList}");
            var backs = JsonConvert.DeserializeObject<List<Backup>>(BackupList);

            if (backs is null)
                throw new Exception("BackupList returned null");
            return backs;
        }

        public static void SetBackups(this List<Backup> s)
        {
            DirCheck();
            File.WriteAllText(BackupList, JsonConvert.SerializeObject(s));
        }
    }

    public class Settings
    {
        // Settings menu
        public bool Animations = true;
        public int CurvePercent = 50;
        public bool CurveForm = true;
        public bool SaveOnExit = true;
        public bool SaveAppSettings = false;
        public bool StartWindowsOnLaunch = false;

        // Other variables
        public bool IsOpen = true;
        public bool CreateDebugLog = false;
        public Severity MinSeverity = Severity.Log;

        public FieldInfo[] RetSet()
        {
            return GetType().GetFields();
        }

        ~Settings()
        {
            this.GetClassFields().NullifyFields(this);
            ErrorHandling.WriteExit(this);
        }
    }

    public class AppSettings
    {
        public bool ConsoleEnabled = false;
        public bool ChangesMade = false;
        public bool IsClosing = false;
        public bool SettingsLoaded = false;

        // Open forms
        public bool DebugFormEnabled = false;
        public bool SettingsFormEnabled = false;
        public bool NewBackupFormEnabled = false;

        public FieldInfo[] RetSet()
        {
            return GetType().GetFields();
        }

        ~AppSettings()
        {
            this.GetClassFields().NullifyFields(this);
            ErrorHandling.WriteExit(this);
        }
    }
}
