using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using MediaMinistryManager.Mobile.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MediaMinistryManager.Mobile.Utils;

namespace MediaMinistryManager.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InventoryManagementView : ContentPage
    {
        private Database db;
        public InventoryManagementView()
        {
            InitializeComponent();
            db = new Database();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            Inventory.ItemsSource = await db.getInventory();
        }

        async void ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ProductManagementPage
                {
                    BindingContext = e.SelectedItem as InventoryItem
                });
            }

            ((ListView)sender).SelectedItem = null;
        }

        async void OnProductAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddProductPage());
        }
    }
}
