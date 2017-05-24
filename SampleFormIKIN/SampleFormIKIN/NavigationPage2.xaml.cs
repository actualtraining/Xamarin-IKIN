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
    public partial class NavigationPage2 : ContentPage
    {
        private Pegawai objPegawai;
        public NavigationPage2(Pegawai objPegawai)
        {
            InitializeComponent();
            this.objPegawai = objPegawai;
        }

        private void btnKembali_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private async void btnDisplay_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Keterangan", 
                objPegawai.Nik + " - " + objPegawai.Nama + " - " + objPegawai.Email,"OK");
        }
    }
}