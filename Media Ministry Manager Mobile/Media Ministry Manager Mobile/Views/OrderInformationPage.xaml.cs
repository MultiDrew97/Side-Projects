using MediaMinistryManagerMobile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MediaMinistryManagerMobile.Utils;

namespace MediaMinistryManagerMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderInformationPage : ContentPage
    {
        Database db;
        OrderSummary order;
        Customer customer;
        public OrderInformationPage()
        {
            InitializeComponent();
            db = new Database();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            order = (OrderSummary)BindingContext;
            customer = await db.getCustomer(order.phone_number);
            InfoPage.Title = customer.FIRST_NAME + "'S Order";
        }

        public async void CompleteOrderClicked(object sender, EventArgs e)
        {
            var currentItem = await getCurrentItem();

            if (currentItem.in_stock >= order.quantity)
            {

                var completed = new Orders
                {
                    order_number = order.order_number,
                    phone_number = order.phone_number
                };

                var updatedItem = new InventoryItem
                {
                    item_index = currentItem.item_index,
                    item = currentItem.item,
                    in_stock = currentItem.in_stock - order.quantity,
                    price = currentItem.price
                };

                await db.completeOrder(completed);
                await db.updateProduct(updatedItem);
            }
            else
            {
                await DisplayAlert("Insufficient Stock", $"There is not enough {currentItem.item} in stock to complete this order", "Ok");
            }
        }

        public async void CancelOrderClicked(object sender, EventArgs e)
        {
            if (await db.cancelOrder_Counts(order.order_number))
            {
                await db.cancelOrder(order.order_number);
                await Navigation.PopAsync();
            }
        }

        private async Task<InventoryItem> getCurrentItem()
        {
            var inventory = await db.getInventory();
            var itemTemp = new InventoryItem();

            foreach (var itemLoop in inventory)
            {
                if (itemLoop.item.Equals(order.item))
                {
                    itemTemp = itemLoop;
                }
            }

            return itemTemp;
        }
    }
}