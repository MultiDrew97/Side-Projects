using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MediaMinistryManager.Mobile.Models;
using System.Text.RegularExpressions;
using MediaMinistryManager.Mobile.Utils;

namespace MediaMinistryManager.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddCustomerPage : ContentPage
    {
        readonly Database db;
        Customer newCustomer;
        public AddCustomerPage()
        {
            InitializeComponent();
            db = new Database();
        }
        
        async private void AddCustomer_Clicked(object sender, EventArgs e)
        {
            CheckUnimportant();

            newCustomer = new Customer
            {
                FIRST_NAME = FirstName.Text.ToUpper(),
                LAST_NAME = LastName.Text.ToUpper(),
                SHIPPING_STREET = Street.Text.ToUpper(),
                SHIPPING_CITY = City.Text.ToUpper(),
                SHIPPING_STATE = State.Text.ToUpper(),
                SHIPPING_ZIP = ZipCode.Text.Length >= 5 ? ZipCode.Text.Substring(0, 5) : ZipCode.Text,
                PHONE_NUMBER = PhoneNumber.Text,
                EMAIL = Email.Text.ToUpper(),
                PREFERRED_PAYMENT = Payment.Text.Length >= 4 ? Payment.Text.ToUpper().Substring(0, 4) : Payment.Text
            };

            if (await IsValid())
            {
                if (await db.addCustomer(newCustomer))
                {
                    await DisplayAlert("Success", FirstName.Text + " " + LastName.Text + " has been added to the list.", "Ok");
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Something Went Wrong", FirstName.Text + " " + LastName.Text + " could not be added.", "Try Again");
                }
            }
        }

        async private void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        void CheckUnimportant()
        {
            if (string.IsNullOrEmpty(Street.Text))
                Street.Text = "";
            if (string.IsNullOrEmpty(City.Text))
                City.Text = "";
            if (string.IsNullOrEmpty(State.Text))
                State.Text = "";
            if (string.IsNullOrEmpty(ZipCode.Text))
                ZipCode.Text = "";
            if (string.IsNullOrEmpty(Email.Text))
                Email.Text = "";
            if (string.IsNullOrEmpty(Payment.Text))
                Payment.Text = "";
        }

        async private Task<bool> IsValid()
        {

            if (string.IsNullOrWhiteSpace(newCustomer.FIRST_NAME) || string.IsNullOrWhiteSpace(newCustomer.LAST_NAME) || string.IsNullOrWhiteSpace(newCustomer.PHONE_NUMBER))
            {
                if (string.IsNullOrWhiteSpace(newCustomer.FIRST_NAME))
                {
                    await DisplayAlert("Empty First Name", "Please enter a first name for the person.", "Ok");
                }
                else if (string.IsNullOrWhiteSpace(newCustomer.LAST_NAME))
                {
                    await DisplayAlert("Empty Last Name", "Please enter a last name for the person.", "Ok");
                }
                else
                {
                    await DisplayAlert("Empty Phone Number", "Please enter a phone number for the person.", "Ok");
                }
                return false;
            }

            return true;
        }

        bool ValidNumber()
        {
            return PhoneNumber.Text.Length == 10;
        }
        void UnfocusedEvent(object sender, EventArgs e)
        {
            //see https://stackoverflow.com/questions/188510/how-to-format-a-string-as-a-telephone-number-in-c-sharp
            //for more ways to format the phone number
            if (ValidNumber())
            {
                PhoneNumber.Text = Regex.Replace(PhoneNumber.Text, @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
            }
        }

        void checkZip(object sender, EventArgs e)
        {
            ZipCode.Text = ZipCode.Text.Length > 5 ? ZipCode.Text.Substring(0, 5) : ZipCode.Text;
        }

        void checkPhone(object sender, EventArgs e)
        {
            if (!PhoneNumber.Text.Contains("-"))
                PhoneNumber.Text = PhoneNumber.Text.Length > 10 ? PhoneNumber.Text.Substring(0, 10) : PhoneNumber.Text;
            //else
            //    PhoneNumber.Text = PhoneNumber.Text.Substring(0, 12);
        }
    }
}