using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite.Net.Attributes;

namespace SampleFormIKIN.Model
{
    public class Pegawai
    {
        [PrimaryKey]
        public string Nik { get; set; }
        [NotNull]
        public string Nama { get; set; }
        public int Umur { get; set; }
        public string  Email { get; set; }
        public string Pic { get; set; }
    }
}
