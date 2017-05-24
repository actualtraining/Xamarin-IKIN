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
    public partial class MasterPage : ContentPage
    {

        public ListView myListView { get { return listView; } }
        public MasterPage()
        {
            InitializeComponent();

            var listMaster = new List<MasterPageItem>
            {
                new MasterPageItem{Title="Home",IconSource="icon.png",TargetType=typeof(MainPage)},
                new MasterPageItem{Title="Contact",IconSource="icon.png",TargetType=typeof(ContactPage)},
                new MasterPageItem{Title="Pegawai",IconSource="icon.png",TargetType=typeof(SampleCustomList)}
            };

            listView.ItemsSource = listMaster;
        }
    }
}