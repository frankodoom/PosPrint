using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosPrint.Model
{
    class PurchaseViewModel
    {
        public Guid ProductID { get; set; }
        public string TransactionType { get; set; }
        public int Quantity { get; set; }
    }
}
