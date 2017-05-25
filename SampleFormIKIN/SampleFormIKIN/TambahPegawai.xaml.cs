using SampleFormIKIN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleFormIKIN
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TambahPegawai : ContentPage
    {
        public TambahPegawai()
        {
            InitializeComponent();
        }

        private async void btnTambah_Clicked(object sender, EventArgs e)
        {
            var newPegawai = new Pegawai
            {
                Nik = txtNik.Text,
                Nama=txtNama.Text,
                Email = txtEmail.Text,
                Umur = Convert.ToInt32(txtUmur.Text)
            };

            try
            {
                App.DbUtils.SavePegawai(newPegawai);
                await DisplayAlert("Keterangan", "Data berhasil ditambah !", "OK");   
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", "Kesalahan : " + ex.Message, "OK");
            }
        }
    }
}