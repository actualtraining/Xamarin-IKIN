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
    public partial class DetailForm : ContentPage
    {
        private Dictionary<string, string> dictBahasa;
        public DetailForm()
        {
            InitializeComponent();

            dictBahasa = new Dictionary<string, string>
            {
                { "satu", "C#" },{"dua","VB"},{"tiga","Kotlin"},{"empat","Java"}
            };

           

            foreach(var myPick in dictBahasa)
            {
                samplePicker.Items.Add(myPick.Value);
            }
        }

        private async void samplePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var strValue = dictBahasa.FirstOrDefault(x => x.Value == samplePicker.SelectedItem.ToString()).Key;
            await DisplayAlert("Keterangan", "Anda memilih:" + strValue , "OK");
        }
    }
}