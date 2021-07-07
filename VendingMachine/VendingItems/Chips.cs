using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineProject.VendingItems
{
    public class Chips : VendingItem
    {
        public Chips(string info, int price)
            : base(info, price)
        {
        }

        public override string Examine()
        {
            return $"Info: {this.Info}.\nPrice: {this.Price}kr.";
        }

        public override string Use()
        {
            return "Open the package by the sides.";
        }
    }
}
