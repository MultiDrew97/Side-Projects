using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MediaMinistryManager.Mobile.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MediaMinistryManager.Mobile.Utils;

namespace MediaMinistryManager.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomerInformationPage : ContentPage
    {
        private readonly Database db;
        private Customer customer;
        private string oldPhone;
        public CustomerInformationPage()
        {
            InitializeComponent();
            db = new Database();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            customer = (Customer)BindingContext;
            oldPhone = customer.PHONE_NUMBER;
            InfoPage.Title = customer.FIRST_NAME + "'S Information";
        }

        public async void OnUpdateClicked(object sender, EventArgs e)
        {
            var newInfo = new Customer
            {
                FIRST_NAME = FirstName.Text,
                LAST_NAME = LastName.Text,
                SHIPPING_STREET = Street.Text,
                SHIPPING_CITY = City.Text,
                SHIPPING_STATE = State.Text.ToUpper(),
                SHIPPING_ZIP = Zip.Text,
                PHONE_NUMBER = PhoneNumber.Text,
                EMAIL = Email.Text,
                PREFERRED_PAYMENT = PaymentPreference.Text,
                JOIN_DATE = JoinDate.Detail
            };

            if (await db.updateCustomer(newInfo, oldPhone))
            {

                await DisplayAlert("Updated", FirstName.Text + " " + LastName.Text + " has been successfully updated", "Ok");
                await Navigation.PopAsync();
            }
            else
            {

                await DisplayAlert("Not Updated", FirstName.Text + " " + LastName.Text + " was not successfully updated", "Edit");
            }
        }

        public async void OnRemoveClicked(object sender, EventArgs e)
        {

            if (await DisplayAlert("Are You Sure?", "Are you sure you want to delete " + FirstName.Text + " " + LastName.Text + "?", "Remove", "Cancel"))
            {
                //user for sure wants to remove person
                var phone = PhoneNumber.Text;

                var deleted = await db.removeCustomer(phone);

                if (deleted)
                {
                    await DisplayAlert("Removed", FirstName.Text + " " + LastName.Text + " has been successfully removed", "Ok");
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Not Removed", FirstName.Text + " " + LastName.Text + " was not successfully removed", "Try Again");
                }
            }
        }

        private void UnfocusedEvent(object sender, EventArgs e)
        {
            if (validNumber()) {
                PhoneNumber.Text = Regex.Replace(PhoneNumber.Text, @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
            }
        }

        private bool validNumber()
        {
            return PhoneNumber.Text.Length == 10;
        }
    }
}