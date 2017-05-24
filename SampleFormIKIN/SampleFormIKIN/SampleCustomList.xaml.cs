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
            var detailForm = new DetailForm();
            detailForm.BindingContext = objPegawai;
            await Navigation.PushModalAsync(detailForm);
        }

        private async void btnShowAlert_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Konfirmasi", "Pertanyaan ?", "Yes", "No");
            if (result)
                await DisplayAlert("Keterangan", "Anda menjawab yes", "OK");
            else
                await DisplayAlert("Keterangan", "Anda menjawab no", "OK");
        }

        private async void btnActionSheet_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayActionSheet("Pilihan?", "Cancel", null,
                "C#", "VB", "Java", "Kotlin");
            await DisplayAlert("Keterangan", "Anda memilih " + result,"OK");
        }
    }
}