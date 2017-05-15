using System;
using MyOrder.Persistence;
using SQLite;
using System.IO;
using Xamarin.Forms;
using MyOrder.Droid.Persistence;

[assembly:Dependency(typeof(SQLiteDb))]

namespace MyOrder.Droid.Persistence
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentPath, "MySQLite.db3");

            return new SQLiteAsyncConnection(path);
        }
    }
}