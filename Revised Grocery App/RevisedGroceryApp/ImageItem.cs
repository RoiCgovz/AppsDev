using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisedGroceryApp.HelperClasses
{
    public class ImageItem
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }
        public int Stock { get; set; }
        public byte[] ImageBytes { get; set; }
    }
}
