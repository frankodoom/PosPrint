using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosPrint.Model
{
    class Inventory
    {

        public Guid BranchID { get; set; }
        public Guid InventoryID { get; set; }
        public DateTime  Date{ get; set; }
        public Guid ProductID { get; set; }
        public Guid UserID { get; set; }
        
        public string TransactionType { get; set; }
        public int Quantity { get; set; }
        public int Balance { get; set; }

       
        
    }
}
