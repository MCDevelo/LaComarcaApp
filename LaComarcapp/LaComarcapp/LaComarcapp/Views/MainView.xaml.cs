using LaComarcapp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LaComarcapp.Views
{
    public partial class MainView : MasterDetailPage
    {
        private ListView mPage = new ListView();
        public MainView()
        {
            InitializeComponent();

            mPage = (ListView)MasterPage.FindByName("ListViewMenu");
            
            mPage.ItemSelected += SelectedItemFunction;
        }

        private void SelectedItemFunction(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as OpcionesMenuModel;

            if(item == null)
            {
                return;
            }
            var page = (Page)Activator.CreateInstance(item.TipoVista);
            page.Title = item.Titulo;
            Detail = new NavigationPage(page);
            IsPresented = false;
        }
    }
}