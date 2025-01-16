using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Models;

public class Product
{
    public string Name { get; set; }
    public string Unit { get; set; } 
    public int Quantity { get; set; }
    public bool IsPurchased { get; set; }

    public Product(string name, string unit, int quantity)
    {
        Name = name;
        Unit = unit;
        Quantity = quantity;
        IsPurchased = false;
    }
}

