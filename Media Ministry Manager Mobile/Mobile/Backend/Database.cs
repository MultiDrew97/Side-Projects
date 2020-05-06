#region USING/NAMESPAES
using System.Collections.Generic;
//figured out how to use this from https://social.msdn.microsoft.com/Forums/en-US/ec2361a3-1931-4423-bf68-08b206ce67aa/reference-systemdatasqlclient-not-found?forum=netfxbcl
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Text;
using System.Diagnostics;
using MediaMinistryManager.Mobile.Models;
#endregion

namespace MediaMinistryManager.Mobile.Utils
{
    class Database
    {
        #region GLOBALS
        HttpClient _client;
        #endregion

        #region CONSTRUCT/DESTRUCT
        public Database()
        {
            _client = new HttpClient();
        }

        ~Database()
        {
            _client.Dispose();
        }
        #endregion

        #region CUSTOMERS
        public async Task<ObservableCollection<Customer>> getCustomers()
        {
            var customers = new ObservableCollection<Customer>();
            var uri = String.Format("{0}customers", Constants.REST_API);

            var response = await _client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                customers = JsonConvert.DeserializeObject<ObservableCollection<Customer>>(content);
            }

            return customers;
        }

        public async Task<Customer> getCustomer(string phoneNumber)
        {
            var customer = new Customer();
            var uri = string.Format("{0}customers/{1}", Constants.REST_API, phoneNumber);

            var response = await _client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                customer = JsonConvert.DeserializeObject<Customer>(content);
            }

            return customer;
        }

        public async Task<bool> addCustomer(Customer newCustomer)
        {
            //found how to get the date in my desired format from
            //https://stackoverflow.com/questions/3025361/c-sharp-datetime-to-yyyymmddhhmmss-format
            var today = DateTime.Today.ToString("yyyy/MM/dd");
            newCustomer.JOIN_DATE = today;

            var uri = string.Format("{0}customers", Constants.REST_API);

            var json = JsonConvert.SerializeObject(newCustomer);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(uri, content);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> updateCustomer(Customer newInfo, string oldPhone)
        {
            var uri = string.Format("{0}customers/{1}", Constants.REST_API, oldPhone);
            var json = JsonConvert.SerializeObject(newInfo);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PutAsync(uri, content);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> removeCustomer(string phoneNumber)
        {
            var uri = string.Format("{0}customers/{1}", Constants.REST_API, phoneNumber);

            var response = await _client.DeleteAsync(uri);

            return response.IsSuccessStatusCode;
        }
        #endregion

        #region INVENTORY
        public async Task<ObservableCollection<InventoryItem>> getInventory()
        {
            var inventory = new ObservableCollection<InventoryItem>();

            var uri = string.Format("{0}inventory", Constants.REST_API);

            try
            {
                var response = await _client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    inventory = JsonConvert.DeserializeObject<ObservableCollection<InventoryItem>>(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return inventory;
        }

        public async Task<InventoryItem> getItem(int index)
        {
            var item = new InventoryItem();

            var uri = string.Format("{0}inventory/{1}", Constants.REST_API, index);

            try
            {
                var response = await _client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    item = JsonConvert.DeserializeObject<InventoryItem>(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return item;
        }

        public async Task<bool> updateProduct(InventoryItem newInfo)
        {
            var uri = string.Format("{0}inventory/{1}", Constants.REST_API, newInfo.item_index);

            var json = JsonConvert.SerializeObject(newInfo);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PutAsync(uri, content);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> addNewProduct(InventoryItem newItem)
        {
            var uri = string.Format("{0}inventory/", Constants.REST_API);

            var json = JsonConvert.SerializeObject(newItem);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync(uri, content);

            return response.IsSuccessStatusCode;

        }

        public async Task<bool> removeProduct(int index)
        {
            var uri = string.Format("{0}inventory/{1}", Constants.REST_API, index);


            var response = await _client.DeleteAsync(uri);

            return response.IsSuccessStatusCode;
        }
        #endregion

        #region ORDERS
        public async Task<ObservableCollection<OrderSummary>> getOrderSummary()
        {
            var orders = new ObservableCollection<OrderSummary>();

            var uri = string.Format("{0}ordersummary", Constants.REST_API);

            try
            {
                var response = await _client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    orders = JsonConvert.DeserializeObject<ObservableCollection<OrderSummary>>(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return orders;
        }

        public async Task<List<OrderSummary>> getOrderSummary(string phoneNumber)
        {
            //UPDATE SO THAT THIS WILL FIND THE ORDER SUMMARY FOR THE GIVEN PHONE NUMBER
            var allSummary = await getOrderSummary();

            var orders = new List<OrderSummary>();

            foreach (var order in allSummary)
            {
                if (order.phone_number.Equals(phoneNumber))
                    orders.Add(order);
            }

            return orders;
        }

        public async Task<bool> placeOrder(Orders newOrder, Order_Counts newCount)
        {
            var uri = string.Format("{0}orders", Constants.REST_API);

            var json = JsonConvert.SerializeObject(newOrder);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(uri, content);

            if (response.IsSuccessStatusCode)
            {
                //the order was added successfully to the orders table
                return await this.addQuantity(newCount);
            }
            else
            {
                return response.IsSuccessStatusCode;
            }
        }

        private async Task<bool> addQuantity(Order_Counts newCount)
        {
            var uri = string.Format("{0}order_counts", Constants.REST_API);

            var json = JsonConvert.SerializeObject(newCount);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(uri, content);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> cancelOrder(int order_number)
        {
            var uri = string.Format("{0}orders/{1}", Constants.REST_API, order_number);

            var response = await _client.DeleteAsync(uri);

            return response.IsSuccessStatusCode;
        }
        public async Task<bool> cancelOrder_Counts(int order_number)
        {
            //return await this.cancelOrder_Counts(await this.getOrderIndex(order_number));
            var uri = string.Format("{0}ordercounts/{1}", Constants.REST_API, await this.getOrderIndex(order_number));

            var response = await _client.DeleteAsync(uri);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> cancelOrder_Counts(Order_Counts counts)
        {
            var uri = string.Format("{0}ordercounts/{1}", Constants.REST_API, counts.order_index);

            //find the order_index of the order with the order number
            var response = await _client.DeleteAsync(uri);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> completeOrder(Orders completed)
        {
            var uri = string.Format("{0}completedorders/", Constants.REST_API);

            var json = JsonConvert.SerializeObject(completed);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(uri, content);

            if (response.IsSuccessStatusCode)
            {
                if (await this.completeOrder_Counts(completed.order_number))
                    if (await this.cancelOrder_Counts(completed.order_number))
                        return await this.cancelOrder(completed.order_number);
                    else
                        return false;
                else
                    return false;

            }
            else
            {
                return false;
            }
        }
        public async Task<bool> completeOrder_Counts(int order_number)
        {
            var counts = await this.getOrderCounts(await this.getOrderIndex(order_number));
            var uri = string.Format("{0}completedordercounts/", Constants.REST_API);

            var json = JsonConvert.SerializeObject(counts);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(uri, content);


            return await this.cancelOrder_Counts(counts);
        }

        public async Task<List<OrderSummary>> getCompletedOrderSummary()
        {
            var orders = new List<OrderSummary>();

            var uri = string.Format("{0}completedordersummary", Constants.REST_API);

            var response = await _client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                orders = JsonConvert.DeserializeObject<List<OrderSummary>>(content);
            }

            return orders;
        }

        public async Task<List<OrderSummary>> getCompletedOrderSummary(string phoneNumber)
        {

            //UPDATE SO THAT THIS WILL ALSO FIND THE ORDER SUMMARY FOR THE GIVEN PHONE NUMBER
            var allSummary = await getCompletedOrderSummary();

            var orders = new List<OrderSummary>();

            foreach (var order in allSummary)
            {
                if (order.phone_number.Equals(phoneNumber))
                    orders.Add(order);
            }

            return orders;
        }

        public async Task<List<Order_Counts>> getCompletedOrderCounts()
        {
            var orders = new List<Order_Counts>();

            var uri = string.Format("{0}completedordercounts", Constants.REST_API);

            var response = await _client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                orders = JsonConvert.DeserializeObject<List<Order_Counts>>(content);
            }

            return orders;
        }

        public async Task<List<Order_Counts>> getOrderCounts()
        {
            var orders = new List<Order_Counts>();

            var uri = string.Format("{0}ordercounts", Constants.REST_API);

            var response = await _client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                orders = JsonConvert.DeserializeObject<List<Order_Counts>>(content);
            }

            return orders;
        }
        #endregion

        #region SUPPLEMENTAL
        private async Task<int> getOrderIndex(int order_number)
        {
            var foundIndex = -1;
            List<Order_Counts> order_counts;
            var uri = string.Format("{0}order_counts/", Constants.REST_API);

            try
            {
                var response = await _client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    order_counts = JsonConvert.DeserializeObject<List<Order_Counts>>(content);

                    foreach (var order_count in order_counts)
                    {
                        if (order_count.order_number == order_number)
                        {
                            return order_count.order_index;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return foundIndex;
        }

        private async Task<Order_Counts> getOrderCounts(int order_index)
        {
            var uri = string.Format("{0}order_counts/{1}", Constants.REST_API, order_index);
            var order_counts = new Order_Counts();
            var response = await _client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                order_counts = JsonConvert.DeserializeObject<Order_Counts>(content);
            }

            return order_counts;
        }
        #endregion

        #region Listeners
        public async Task<ObservableCollection<Listener>> getListeners()
        {
            var listeners = new ObservableCollection<Listener>();
            var uri = String.Format("{0}listeners", Constants.REST_API);

            var response = await _client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                listeners = JsonConvert.DeserializeObject<ObservableCollection<Listener>>(content);
            }

            return listeners;
        }

        public async Task<Listener> getListener(string email)
        {
            var listener = new Listener();
            var uri = String.Format("{0}listeners/{1}", Constants.REST_API, email);

            var response = await _client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                listener = JsonConvert.DeserializeObject<Listener>(content);
            }

            return listener;
        }

        public async Task<bool> addListener(Listener listener)
        {
            var uri = String.Format("{0}listeners", Constants.REST_API);
            var json = JsonConvert.SerializeObject(listener);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PostAsync(uri, content);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> addListener(string name, string email)
        {
            return await addListener(new Listener() { NAME = name, EMAIL = email });
        }

        public async Task<bool> updateListener(Listener listener, string oldEmail)
        {
            var uri = String.Format("{0}listeners/{1}", Constants.REST_API, oldEmail);
            var json = JsonConvert.SerializeObject(listener);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _client.PutAsync(uri, content);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> removeListener(string email)
        {
            var uri = String.Format("{0}listeners/{1}", Constants.REST_API, email);

            var request = await _client.DeleteAsync(uri);

            return request.IsSuccessStatusCode;
        }
        #endregion
    }
}
