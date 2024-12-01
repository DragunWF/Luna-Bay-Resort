using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luna_Bay_Resort_App.Data
{
    internal class Inventory
    {
        public class PurchaseOrderItem
        {
            public string ItemName { get; set; }
            public string Quantity { get; set; }
            public string Status { get; set; }
        }

        public static List<PurchaseOrderItem> PurchaseOrderList { get; } = new();
    }
}
