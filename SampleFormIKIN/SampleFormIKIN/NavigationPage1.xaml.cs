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
    public partial class NavigationPage1 : ContentPage
    {
        public NavigationPage1()
        {
            InitializeComponent();
        }

        private async void btnKeHalaman2_Clicked(object sender, EventArgs e)
        {
            var objPegawai = new Pegawai
            {
                Nik = txtNik.Text,
                Nama = txtNama.Text,
                Email = txtEmail.Text,
                Umur = Convert.ToInt32(txtUmur.Text)
            };
            await Navigation.PushAsync(new NavigationPage2(objPegawai));
        }
    }
}