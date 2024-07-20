using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace json_test.models
{
    public class Beer
    {
        public int Quantity { get; set; }
        public string? Category { get; set; }

        public Beer(int quantity, string category)
        {
            Quantity = quantity;
            Category = category;
        }

    }
}