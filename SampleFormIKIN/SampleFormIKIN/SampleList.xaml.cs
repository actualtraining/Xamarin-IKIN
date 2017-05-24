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
    public partial class SampleList : ContentPage
    {
        public SampleList()
        {
            InitializeComponent();

            List<string> lstBahasa = new List<string> { "C#", "Java", "VB", "F#", "Kotlin" };
            lstData.ItemsSource = lstBahasa;

            lstData.ItemTapped += LstData_ItemTapped;
        }

        private void LstData_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            DisplayAlert("Keterangan", e.Item.ToString(), "OK");
        }
    }
}