using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GasUp_Website
{
   
    public class ShoppingCart
    {
        public int id;
        public int quantity;

        public ShoppingCart(int id2, int qua)
        {
            id = id2;
            quantity = qua;
        }
        
    }
}