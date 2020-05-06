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
    public partial class CustomerManagementView : ContentPage
    {
        private Database db;
        public CustomerManagementView()
        {
            InitializeComponent();
            db = new Database();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            Customers.ItemsSource = await db.getCustomers();
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new CustomerInformationPage
                {
                    BindingContext = e.SelectedItem as Customer
                });
            }

            ((ListView)sender).SelectedItem = null;
        }

        async void OnCustomerAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddCustomerPage());
        }
    }
}