using System;
using System.Collections.Generic;
using System.Text;

namespace MediaMinistryManagerMobile.Models
{
    class InventoryItem
    {
        public int item_index { get; set; }
        public string item { get; set; }
        public int in_stock { get; set; }
        public decimal price { get; set; }
    }
}
