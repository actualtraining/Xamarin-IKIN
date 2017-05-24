using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleFormIKIN.Model;

namespace SampleFormIKIN.ViewModel
{
    public class PegawaiViewModel
    {
        private List<Pegawai> lstPegawai;
        public List<Pegawai> ListPegawai
        {
            get { return lstPegawai; }
            set { lstPegawai = value; }
        }

        public PegawaiViewModel()
        {
            lstPegawai = new List<Pegawai>
            {
                new Pegawai{Nik="12345",Nama="Budi Sutejo",Email="budi@gmail.com",Umur=45,Pic="satu.png"},
                new Pegawai{Nik="23456",Nama="Jovan Kurniawan",Email="jovan@gmail.com",Umur=35,Pic="dua.png"}
            };
        }

    }
}
