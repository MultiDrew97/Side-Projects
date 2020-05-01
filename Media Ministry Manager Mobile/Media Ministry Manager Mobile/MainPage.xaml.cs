using MediaMinistryManagerMobile.Models;
using MediaMinistryManagerMobile.Views;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MediaMinistryManagerMobile.Utils;

namespace MediaMinistryManagerMobile
{
    public partial class MainPage : ContentPage
    {
        private Database db = new Database();
        public MainPage()
        {
            InitializeComponent();
        }

        async void CustomerManagmentButtonClickedAsync(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new CustomerManagementView());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public async void InventoryButtonClickedAsync(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new InventoryManagementView());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public async void PlaceOrderButtonClickedAsync(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new PlaceOrderPage());
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        public async void OrderSummaryButtonClickedAsync(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new OrderSummaryView());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
