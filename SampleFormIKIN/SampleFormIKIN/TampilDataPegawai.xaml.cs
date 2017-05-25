﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleFormIKIN
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TampilDataPegawai : ContentPage
    {
        public TampilDataPegawai()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            var listPegawai = App.DbUtils.GetAllPegawai();
            listViewPegawai.ItemsSource = listPegawai;
        }

        private async void btnTambah_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TambahPegawai());
        }
    }
}