using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MediaMinistryManagerMobile.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MediaMinistryManagerMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlaceOrderPage : ContentPage
    {
        Database db;
        List<string> customerNames, phoneNumbers, itemNames;
        public ObservableCollection<string> Items { get; set; }

        public PlaceOrderPage()
        {
            InitializeComponent();
            db = new Database();
            getSources();
        }

        //protected async override void OnAppearing()
        //{
        //    base.OnAppearing();

        //    var customers = await db.getCustomers();
        //    var phoneNumbers = new List<string>();
        //    var lastNames = new List<string>();
        //    foreach (var customer in customers)
        //    {
        //        phoneNumbers.Add(customer.PHONE_NUMBER);
        //        lastNames.Add(customer.LAST_NAME);
        //    }

        //    var items = await db.getInventory();
        //    var itemNames = new List<string>();
        //    foreach (var item in items)
        //    {
        //        itemNames.Add(item.item);
        //    }

        //    NamePicker.ItemsSource = lastNames;
        //    PhonePicker.ItemsSource = phoneNumbers;
        //    ItemPicker.ItemsSource = itemNames;
        //}

        async void PlaceOrderClicked(object sender, EventArgs e)
        {

            var nums = await FindIndexAndNumber();

            Orders newOrder = new Orders
            {
                order_number = nums[0],
                phone_number = PhonePicker.SelectedItem.ToString()
            };

            Order_Counts newCount = new Order_Counts
            {
                order_index = nums[1],
                order_number = nums[0],
                item_index = ItemPicker.SelectedIndex,
                quantity = int.Parse(entQuantity.Text),
            };

            if (await db.placeOrder(newOrder, newCount))
            {
                await DisplayAlert($"{NamePicker.SelectedItem.ToString()}'s Order", $"{NamePicker.SelectedItem.ToString()}'s order has been placed.", "Ok");
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("Something Went Wrong", $"{NamePicker.SelectedItem.ToString()}'s order could not be placed.", "Try Again");
            }
        }

        async public void CancelClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private void NameChanged(object sender, EventArgs e)
        {
            if (PhonePicker.SelectedIndex != NamePicker.SelectedIndex)
                PhonePicker.SelectedIndex = NamePicker.SelectedIndex;
        }

        private void PhoneChanged(object sender, EventArgs e)
        {
            if (NamePicker.SelectedIndex != PhonePicker.SelectedIndex)
                NamePicker.SelectedIndex = PhonePicker.SelectedIndex;
        }

        private async Task<int[]> FindIndexAndNumber()
        {
            //numbers[0] = order_number
            //numbers[1] = order_index
            var numbers = new int[2];

            #region ORDER_NUMBER
            var orders = await db.getOrderSummary();
            var ordersArray = orders.ToArray();
            var max = -1;

            if (ordersArray.Length > 0)
            {
                max = ordersArray[0].order_number;


                for (var i = 1; i < ordersArray.Length; i++)
                {
                    if (max < ordersArray[i].order_number)
                        max = ordersArray[i].order_number;
                }
            }

            var completedOrders = await db.getCompletedOrderSummary();
            var completedOrdersArray = completedOrders.ToArray();
            var maxCompleted = -1;

            if (completedOrdersArray.Length > 0)
            {
                maxCompleted = completedOrdersArray[0].order_number;

                for (var i = 1; i < completedOrdersArray.Length; i++)
                {
                    if (maxCompleted < completedOrdersArray[i].order_number)
                        maxCompleted = completedOrdersArray[i].order_number;
                }
            }

            if ((maxCompleted + 1) > (max + 1))
            {
                numbers[0] = (maxCompleted + 1);
            }
            else
            {
                numbers[0] = (max + 1);
            }
            #endregion

            #region ORDER_INDEX
            var order_counts = await db.getOrderCounts();
            var order_countsArray = order_counts.ToArray();
            var maxOrderCounts = -1;

            if (order_countsArray.Length > 0)
            {
                maxOrderCounts = order_countsArray[0].order_index;

                for (var i = 1; i < order_countsArray.Length; i++)
                {
                    if (maxOrderCounts < order_countsArray[i].order_index)
                        maxOrderCounts = order_countsArray[i].order_index;
                }
            }

            var completedOrderCounts = await db.getCompletedOrderCounts();
            var completedOrderCountsArray = completedOrderCounts.ToArray();
            var maxCompletedOrderCounts = -1;

            if (completedOrderCountsArray.Length > 0)
            {
                maxCompletedOrderCounts = completedOrdersArray[0].order_number;

                for (var i = 1; i < completedOrderCountsArray.Length; i++)
                {
                    if (maxCompletedOrderCounts < completedOrderCountsArray[i].order_index)
                        maxCompletedOrderCounts = completedOrderCountsArray[i].order_index;
                }
            }


            if ((maxCompletedOrderCounts + 1) > (maxOrderCounts + 1))
            {
                numbers[1] = (maxCompletedOrderCounts + 1);
            }
            else
            {
                numbers[1] = (maxOrderCounts + 1);
            }
            #endregion

            return numbers;
        }

        private async void getSources()
        {
            var customers = await db.getCustomers();
            phoneNumbers = new List<string>();
            customerNames = new List<string>();
            foreach (var customer in customers)
            {
                phoneNumbers.Add(customer.PHONE_NUMBER);
                customerNames.Add(customer.FIRST_NAME + " " + customer.LAST_NAME);
            }

            var items = await db.getInventory();
            itemNames = new List<string>();
            foreach (var item in items)
            {
                itemNames.Add(item.item);
            }

            NamePicker.ItemsSource = customerNames;
            PhonePicker.ItemsSource = phoneNumbers;
            ItemPicker.ItemsSource = itemNames;
        }
    }
}
