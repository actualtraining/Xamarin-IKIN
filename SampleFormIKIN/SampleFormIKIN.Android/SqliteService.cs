using System.IO;
using SampleFormIKIN;
using Xamarin.Forms;
using SampleFormIKIN.Droid;
using SQLite.Net;
using System;

[assembly: Dependency(typeof(SqliteService))]
namespace SampleFormIKIN.Droid
{
    public class SqliteService : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            var sqliteFilename = "Pegawai.db3";
            string documentsPath =
                   Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
            //Console.WriteLine(path);
            if (!File.Exists(path)) File.Create(path);
            var plat = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var conn = new SQLite.Net.SQLiteConnection(plat, path);
            return conn;
        }
    }
}