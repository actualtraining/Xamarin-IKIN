using SampleFormIKIN.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SampleFormIKIN
{
    public partial class App : Application
    {
        private static DataAccessPegawai dbUtils;
        public static DataAccessPegawai DbUtils
        {
            get {
                if (dbUtils == null)
                    dbUtils = new DataAccessPegawai();
                return dbUtils;
            }
        }

        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new SamplePreference());
            MainPage = new NavigationPage(new TampilDataPegawai());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
