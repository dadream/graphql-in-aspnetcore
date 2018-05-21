using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_graphql
{
    public class Item
    {
        public string Barcode { get; set; }

        public string Title { get; set; }

        public decimal SellingPrice { get; set; }
    }
}
