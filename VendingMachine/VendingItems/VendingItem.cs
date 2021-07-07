using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineProject.VendingItems
{
    public abstract class VendingItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VendingItem"/> class.
        /// </summary>
        /// <param name="info">Item info.</param>
        /// <param name="price">Item price.</param>
        public VendingItem(string info, int price)
        {
            this.Info = info;
            this.Price = price;
        }

        /// <summary>
        /// Gets or sets the item info.
        /// </summary>
        public string Info { get; set; }

        /// <summary>
        /// Gets or sets the item price.
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// Shows the item info and price.
        /// </summary>
        public abstract string Examine();

        /// <summary>
        /// Shows how to use the item.
        /// </summary>
        public abstract string Use();
    }
}
