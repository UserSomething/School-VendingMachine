using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineProject.VendingItems
{
    public class Cola : VendingItem
    {
        public Cola(string info, int price)
            : base(info, price)
        {
        }

        public override string Examine()
        {
            //return $"{this.Info}. Price: {this.Price}kr.";
            return $"{this.Info} - {this.Price}kr.";
        }

        public override string Use()
        {
            Console.WriteLine();
            return "Opening the cola: Use a finger to lift the small metal part of the can so it opens.";
        }
    }
}
