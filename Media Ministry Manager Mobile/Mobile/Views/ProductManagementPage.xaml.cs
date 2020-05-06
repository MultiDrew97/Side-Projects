using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaMinistryManager.Mobile.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MediaMinistryManager.Mobile.Utils;

namespace MediaMinistryManager.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductManagementPage : ContentPage
    {
        private Database db;
        InventoryItem inventoryItem;
        private int index;
        public ProductManagementPage()
        {
            InitializeComponent();
            db = new Database();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            inventoryItem = (InventoryItem)BindingContext;
            index = inventoryItem.item_index;
        }

        public async void OnUpdateClicked(object sender, EventArgs e)
        {
            //create a new obejct to store the new information
            var newInfo = new InventoryItem
            {
                item_index = index,
                item = itemName.Text,
                in_stock = int.Parse(currentStock.Text),
                price = decimal.Parse(entPrice.Text.Substring(1))
            };

            if (await db.updateProduct(newInfo))
            {
                //update the product in the table
                await DisplayAlert("Updated", inventoryItem.item + " has been updated.", "Ok");
                await Navigation.PopAsync();
            }
            else
            {
                //have them try to remove the product again
                await DisplayAlert("Not Updated", inventoryItem.item + " could not be updated.", "Try Again");
            }
        }

        public async void OnRemoveClicked(object sender, EventArgs e)
        {

            if (await DisplayAlert("Remove " + inventoryItem.item, "Are you sure you want to remove " + inventoryItem.item + "?", "Remove " + inventoryItem.item, "Cancel"))
            {
                //ensure they want to remove the product
                if (await db.removeProduct(index))
                {
                    //remove the product from the table
                    await DisplayAlert("Removed", inventoryItem.item + " has been removed.", "Ok");
                    await Navigation.PopAsync();
                }
                else
                {
                    //have them try to remove the product again
                    await DisplayAlert("Not Removed", inventoryItem.item + " could not be removed.", "Try Again");
                }
            }
        }

        public void FocusedEvent(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(entPrice.Text))
            {
                entPrice.Text = entPrice.Text.Substring(1);
            }
        }
        public void UnfocusedEvent(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(entPrice.Text))
            {
                entPrice.Text = string.Format("${0:F2}", entPrice.Text);
            }
        }
    }
}