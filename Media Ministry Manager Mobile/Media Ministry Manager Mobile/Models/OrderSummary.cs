using System;
using System.Collections.Generic;
using System.Text;

namespace MediaMinistryManagerMobile.Models
{
    class OrderSummary
    {
        public int order_number { get; set; }
        public string phone_number { get; set; }
        public string item { get; set; }
        public int quantity { get; set; }
    }
}
