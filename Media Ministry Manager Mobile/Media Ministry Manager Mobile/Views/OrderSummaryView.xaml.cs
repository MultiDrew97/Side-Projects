using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MediaMinistryManagerMobile.Models;
using System.Collections.Generic;
using MediaMinistryManagerMobile.Utils;

namespace MediaMinistryManagerMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderSummaryView : ContentPage
    {
        private ObservableCollection<OrderSummary> orderSummary { get; set; }
        private Database db;
        public OrderSummaryView()
        {
            InitializeComponent();

            db = new Database();
            //getSource();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            getSource();
            //try
            //{
            //    orderSummary = await db.getOrderSummary();
            //    Orders.ItemsSource = orderSummary;
            //}
            //catch (Exception ex)
            //{
            //    await DisplayAlert("Something Went Wrong...", ex.Message, "Ok");
            //    await Navigation.PopAsync();
            //}
        }

        async void OrderSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
                await Navigation.PushAsync(new OrderInformationPage
                {
                    BindingContext = e.SelectedItem as OrderSummary
                });
        }

        private async void getSource()
        {
            try
            {
                orderSummary = await db.getOrderSummary();
                Orders.ItemsSource = orderSummary;

                if (orderSummary.Count == 0)
                {
                    NoOrderLabel.IsVisible = true;
                    Orders.IsVisible = false;
                } else
                {
                    Orders.IsVisible = true;
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Something Went Wrong...", ex.Message, "Ok");
                await Navigation.PopAsync();
            }
        }
    }
}
