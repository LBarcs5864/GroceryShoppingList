using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace GroceryShoppingList
{
    public class Item  
    {
        // Properties
        public string Ingredient { get; set; }
        public double Quantity { get; set; }
        public string UnitOfMeasure { get; set; }

        Dictionary<string, Item>[] Categories = new Dictionary<string, Item>[9];

        public Item(string ingredient, double quantity, string unit)
        {   // parametric constructor
            Ingredient = ingredient;
            Quantity = quantity;
            UnitOfMeasure = unit;
        }

        public static void Add(Item resultItem, double extra)
        {
            resultItem.Quantity += extra;
        }

        public static void Subtract(Item resultItem, double excess)
        {
            resultItem.Quantity -= excess;
        }

        public void Display()
        {
            Console.WriteLine($"{Ingredient} {Quantity} {UnitOfMeasure}");
        }
    }
}
