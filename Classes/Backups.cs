using System;
using System.Reflection;

namespace HynusWynus_BackupManager
{
    public class Backup
    {
        public string Name;
        public string DirectoryPath;
        public DateTime Date;
        public int Size;
        public string CompressionType;

        public FieldInfo[] GetItems()
        {
            return GetType().GetFields();
        }
    }
}
