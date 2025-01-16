﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.Models;

public class Category
{
    public string Name { get; set; }
    public List<Product> Products { get; set; }

    public Category(string name)
    {
        Name = name;
        Products = new List<Product>();
    }
}

