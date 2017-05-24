using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleFormIKIN
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnReset.Clicked += BtnReset_Clicked;
        }

        private void BtnReset_Clicked(object sender, EventArgs e)
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
        }

        private void btnSubmit_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Keterangan", "Nama anda :" +
                txtFirstName.Text + " " + txtLastName.Text, "OK");
        }
    }
}
