using SampleFormIKIN.Model;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleFormIKIN.DAL
{
    public class DataAccessPegawai
    {
        SQLiteConnection conn;
        public DataAccessPegawai()
        {
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Pegawai>();
        }

        public List<Pegawai> GetAllPegawai()
        {
            return conn.Query<Pegawai>("select * from Pegawai order by Nama asc");
        }

        public int SavePegawai(Pegawai pegawai)
        {
            return conn.Insert(pegawai);
        }

        public int EditPegawai(Pegawai pegawai)
        {
            return conn.Update(pegawai);
        }

        public int DeletePegawai(Pegawai pegawai)
        {
            return conn.Delete(pegawai);
        }
    }
}
