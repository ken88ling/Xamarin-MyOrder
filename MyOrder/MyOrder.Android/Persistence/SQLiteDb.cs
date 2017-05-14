using System;
using System.IO;
using System.Runtime.CompilerServices;
using MyOrder.Persistence;

[assembly:Dependency(typeof(ISqLiteDb))]

namespace MyOrder.Droid.Persistence
{
    public class SQLiteDb : ISqLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "MySQLite.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}
