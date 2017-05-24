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
    public partial class SamplePreference : ContentPage
    {
        public SamplePreference()
        {
            InitializeComponent();
        }

        private async void btnSetAppCurrent_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["id"] = txtID.Text;
            await DisplayAlert("Keterangan", "Application Current berhasil dibuat !", "OK");
        }

        private async void btnShowAppCurent_Clicked(object sender, EventArgs e)
        {
            if (Application.Current.Properties.ContainsKey("id"))
            {
                string dataID = Application.Current.Properties["id"].ToString();
                await DisplayAlert("Keterangan", "Nilai ID :" + dataID, "OK");
            }
            else
            {
                await DisplayAlert("Keterangan", "Tidak ditemukan !", "OK");
            }
        }
    }
}