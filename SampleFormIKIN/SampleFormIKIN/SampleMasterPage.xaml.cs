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
    public partial class SampleMasterPage : MasterDetailPage
    {
        public SampleMasterPage()
        {
            InitializeComponent();
            masterPage.myListView.ItemSelected += MyListView_ItemSelected;
        }

        private void MyListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                masterPage.myListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}