using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MediaMinistryManagerMobile.Models;
using MediaMinistryManagerMobile.Utils;

namespace MediaMinistryManagerMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddProductPage : ContentPage
    {
        private Database db;
        public AddProductPage()
        {
            InitializeComponent();
            db = new Database();
        }

        async void OnAddClicked(object sender, EventArgs e)
        {
            var temp = await db.getInventory();
            var count = temp.Count;
            var newItem = new InventoryItem
            {
                item_index = count,
                item = itemName.Text,
                in_stock = (int.Parse(string.IsNullOrWhiteSpace(currentStock.Text) ? "0" : currentStock.Text)),
                price = decimal.Parse(string.IsNullOrWhiteSpace(Price.Text) ? "0" : Price.Text.Substring(1))
            };

            if (newItem.item.Equals("") || newItem.price == 0)
            {
                if (newItem.item.Equals(""))
                {
                    await DisplayAlert("Empty Product Name", "Please enter a name for the product.", "Ok");
                }
                else
                {
                    await DisplayAlert("Empty Price", "Please enter a price for the product that is greater than 0.", "Ok");
                }
                return;
            }

            if (await db.addNewProduct(newItem))
            {
                await DisplayAlert("Success", newItem.item + " has been added to the inventory.", "Ok");
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("Something Went Wrong", newItem.item + " could not be added.", "Try Again");
            }
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        public void FocusedEvent(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Price.Text) && Price.Text.StartsWith("$"))
            {
                Price.Text = Price.Text.Replace("$", string.Empty);
            }
                
        }
        public void UnfocusedEvent(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Price.Text))
            {
                //do nothing
            }
            else if (/*!string.IsNullOrWhiteSpace(Price.Text) && */!Price.Text.StartsWith("$"))
            {
                Price.Text = string.Format("${0:F2}", Price.Text);
            }
            else //if (Price.Text.StartsWith("$"))
            {
                Price.Text = string.Format("{0:F2}", Price.Text);
            }
        }
    }
}