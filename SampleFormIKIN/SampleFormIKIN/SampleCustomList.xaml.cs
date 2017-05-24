using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SampleFormIKIN.ViewModel;
using SampleFormIKIN.Model;

namespace SampleFormIKIN
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SampleCustomList : ContentPage
    {
        public SampleCustomList()
        {
            InitializeComponent();
            BindingContext = new PegawaiViewModel();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Pegawai objPegawai = (Pegawai)e.Item;
            await DisplayAlert("Keterangan", "Nik : " + objPegawai.Nik + " Nama :" + objPegawai.Nama +
                " Email :" + objPegawai.Email, "OK");
        }
    }
}