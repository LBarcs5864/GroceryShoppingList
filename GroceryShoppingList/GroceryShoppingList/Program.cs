using System;
using System.IO;
using System.Collections.Generic;

namespace GroceryShoppingList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a dictionary for each category of items
            var produce = new Dictionary<string, Item>();
            var condiments = new Dictionary<string, Item>();
            var meat_poultry = new Dictionary<string, Item>();
            var seafood = new Dictionary<string, Item>();
            var grains_cereals = new Dictionary<string, Item>();
            var beverages = new Dictionary<string, Item>();
            var confections = new Dictionary<string, Item>();
            var dairy_products = new Dictionary<string, Item>();
            var others = new Dictionary<string, Item>();

            // Create an array of each dictionary of categories
            Dictionary<string, Item>[] Categories = { produce, condiments, meat_poultry, seafood, grains_cereals, beverages, confections, dairy_products, others };

            string ingredient = "";
            string quantity = "";
            string quantityAdd = "";
            string quantitySubtract = "";
            string unitOfMeasure = "";
            bool endApp = false;
            while (!endApp)
            {
                Item resultItem;
                double cleanNum = 0;
                Console.Clear();    //Added a clear so console wouldn't get cluttered
                Console.WriteLine("Choose a Category from the following list:");
                Console.WriteLine("\t1 - Produce");
                Console.WriteLine("\t2 - Condiments");
                Console.WriteLine("\t3 - Meat/Poultry");
                Console.WriteLine("\t4 - Seafood");
                Console.WriteLine("\t5 - Grains/Cereals");
                Console.WriteLine("\t6 - Beverages");
                Console.WriteLine("\t7 - Confections");
                Console.WriteLine("\t8 - Dairy Products");
                Console.WriteLine("\t9 - Other");
                Console.WriteLine("\tany other key - End of Shopping list\n");
                Console.Write("Category: ");

                switch (Console.ReadLine())
                {
                    case "1":   // Produce
                        // Ask the user to type the name of item
                        Console.Write("Enter Item: ");
                        ingredient = Console.ReadLine().ToLower();

                        // Check to see if ingredient is already in this dictionary
                        resultItem = produce.ContainsKey(ingredient) ? produce[ingredient] : null;

                        if (resultItem != null)     // if ingredient exists..
                        {
                            do
                            {
                                Console.WriteLine("\t A - Add");
                                Console.WriteLine("\t D - Delete");
                                Console.WriteLine("\t any key - Go to next item");

                                string choice = Console.ReadLine().ToUpper();
                                Console.Clear();
                                switch (choice)
                                {
                                    case "A":
                                        Console.Write("Enter how many you want to add: ");
                                        quantityAdd = Console.ReadLine();
                                        Console.WriteLine();

                                        while (!double.TryParse(quantityAdd, out cleanNum))
                                        {
                                            Console.Write("Invalid input. Please enter a number (no fractions): ");
                                            quantityAdd = Console.ReadLine();
                                            Console.WriteLine();
                                        }
                                        Item.Add(resultItem, double.Parse(quantityAdd));
                                        Console.Write($"UPDATE: "); 
                                            resultItem.Display();
                                        Console.Write("Are you satisfied with your changes? [Y/N]");
                                        break;
                                    case "D":
                                        Console.Write("Enter how many you want to subtract: ");
                                        quantitySubtract = Console.ReadLine();
                                        Console.WriteLine();

                                        while (!double.TryParse(quantitySubtract, out cleanNum))
                                        {
                                            Console.Write("Invalid input. Please enter a number (no fractions): ");
                                            quantitySubtract = Console.ReadLine();
                                            Console.WriteLine();
                                        }
                                        Item.Subtract(resultItem, double.Parse(quantitySubtract));
                                        resultItem.Display();
                                        Console.Write("Are you satisfied with your changes? [Y/N]");
                                        break;
                                    default:
                                        break;
                                }
                            }
                            while (Console.ReadLine().ToLower() != "y");
                        }
                        else
                        {
                            // Ask the user to type the quantity
                            Console.Write("Quantity: ");
                            quantity = Console.ReadLine();

                            while (!double.TryParse(quantity, out cleanNum))
                            {
                                Console.Write("Invalid input. Please enter a number (no fractions): ");
                                quantity = Console.ReadLine();
                            }

                            // Ask the user for the unit of measure
                            Console.Write("Unit of Measure: ");
                            unitOfMeasure = Console.ReadLine();

                            var newItem = new Item(ingredient, double.Parse(quantity), unitOfMeasure);
                            produce.Add(ingredient, newItem);
                        }
                        break;
                    case "2":   // Condiments
                        // Ask the user to type the name of item
                        Console.Write("Enter Item: ");
                        ingredient = Console.ReadLine().ToLower();

                        // Check to see if ingredient is already in this dictionary
                         resultItem = condiments.ContainsKey(ingredient) ? condiments[ingredient] : null;

                        if (resultItem != null)     // if ingredient exists..
                        {
                            do
                            {
                                Console.WriteLine("\t A - Add");
                                Console.WriteLine("\t D - Delete");
                                Console.WriteLine("\t any key - Go to next item");

                                string choice = Console.ReadLine().ToUpper();
                                Console.Clear();
                                switch (choice)
                                {
                                    case "A":
                                        Console.Write("Enter how many you want to add: ");
                                        quantityAdd = Console.ReadLine();
                                        Console.WriteLine();

                                        while (!double.TryParse(quantityAdd, out cleanNum))
                                        {
                                            Console.Write("Invalid input. Please enter a number (no fractions): ");
                                            quantityAdd = Console.ReadLine();
                                            Console.WriteLine();
                                        }
                                        Item.Add(resultItem, double.Parse(quantityAdd));
                                        Console.Write($"UPDATE: ");
                                        resultItem.Display();
                                        Console.Write("Are you satisfied with your changes? [Y/N]");
                                        break;
                                    case "D":
                                        Console.Write("Enter how many you want to subtract: ");
                                        quantitySubtract = Console.ReadLine();
                                        Console.WriteLine();

                                        while (!double.TryParse(quantitySubtract, out cleanNum))
                                        {
                                            Console.Write("Invalid input. Please enter a number (no fractions): ");
                                            quantitySubtract = Console.ReadLine();
                                            Console.WriteLine();
                                        }
                                        Item.Subtract(resultItem, double.Parse(quantitySubtract));
                                        resultItem.Display();
                                        Console.Write("Are you satisfied with your changes? [Y/N]");
                                        break;
                                    default:
                                        break;
                                }
                            }
                            while (Console.ReadLine().ToLower() != "y");
                        }
                        else
                        {
                            // Ask the user to type the quantity
                            Console.Write("Quantity: ");
                            quantity = Console.ReadLine();

                            while (!double.TryParse(quantity, out cleanNum))
                            {
                                Console.Write("Invalid input. Please enter a number (no fractions): ");
                                quantity = Console.ReadLine();
                            }

                            // Ask the user for the unit of measure
                            Console.Write("Unit of Measure: ");
                            unitOfMeasure = Console.ReadLine();

                            var newItem = new Item(ingredient, double.Parse(quantity), unitOfMeasure);
                            condiments.Add(ingredient, newItem);
                        }
                        break;
                    case "3":   // Meat_Poultry
                        // Ask the user to type the name of item
                        Console.Write("Enter Item: ");
                        ingredient = Console.ReadLine().ToLower();

                        // Check to see if ingredient is already in this dictionary
                         resultItem = meat_poultry.ContainsKey(ingredient) ? meat_poultry[ingredient] : null;

                        if (resultItem != null)     // if ingredient exists..
                        {
                            do
                            {
                                Console.WriteLine("\t A - Add");
                                Console.WriteLine("\t D - Delete");
                                Console.WriteLine("\t any key - Go to next item");

                                string choice = Console.ReadLine().ToUpper();
                                Console.Clear();
                                switch (choice)
                                {
                                    case "A":
                                        Console.Write("Enter how many you want to add: ");
                                        quantityAdd = Console.ReadLine();
                                        Console.WriteLine();

                                        while (!double.TryParse(quantityAdd, out cleanNum))
                                        {
                                            Console.Write("Invalid input. Please enter a number (no fractions): ");
                                            quantityAdd = Console.ReadLine();
                                            Console.WriteLine();
                                        }
                                        Item.Add(resultItem, double.Parse(quantityAdd));
                                        Console.Write($"UPDATE: ");
                                        resultItem.Display();
                                        Console.Write("Are you satisfied with your changes? [Y/N]");
                                        break;
                                    case "D":
                                        Console.Write("Enter how many you want to subtract: ");
                                        quantitySubtract = Console.ReadLine();
                                        Console.WriteLine();

                                        while (!double.TryParse(quantitySubtract, out cleanNum))
                                        {
                                            Console.Write("Invalid input. Please enter a number (no fractions): ");
                                            quantitySubtract = Console.ReadLine();
                                            Console.WriteLine();
                                        }
                                        Item.Subtract(resultItem, double.Parse(quantitySubtract));
                                        resultItem.Display();
                                        Console.Write("Are you satisfied with your changes? [Y/N]");
                                        break;
                                    default:
                                        break;
                                }
                            }
                            while (Console.ReadLine().ToLower() != "y");
                        }
                        else
                        {
                            // Ask the user to type the quantity
                            Console.Write("Quantity: ");
                            quantity = Console.ReadLine();

                            while (!double.TryParse(quantity, out cleanNum))
                            {
                                Console.Write("Invalid input. Please enter a number (no fractions): ");
                                quantity = Console.ReadLine();
                            }

                            // Ask the user for the unit of measure
                            Console.Write("Unit of Measure: ");
                            unitOfMeasure = Console.ReadLine();

                            var newItem = new Item(ingredient, double.Parse(quantity), unitOfMeasure);
                            meat_poultry.Add(ingredient, newItem);
                        }
                        break;
                    case "4":   // Seafood
                        // Ask the user to type the name of item
                        Console.Write("Enter Item: ");
                        ingredient = Console.ReadLine().ToLower();

                        // Check to see if ingredient is already in this dictionary
                         resultItem = seafood.ContainsKey(ingredient) ? seafood[ingredient] : null;

                        if (resultItem != null)     // if ingredient exists..
                        {
                            do
                            {
                                Console.WriteLine("\t A - Add");
                                Console.WriteLine("\t D - Delete");
                                Console.WriteLine("\t any key - Go to next item");

                                string choice = Console.ReadLine().ToUpper();
                                Console.Clear();
                                switch (choice)
                                {
                                    case "A":
                                        Console.Write("Enter how many you want to add: ");
                                        quantityAdd = Console.ReadLine();
                                        Console.WriteLine();

                                        while (!double.TryParse(quantityAdd, out cleanNum))
                                        {
                                            Console.Write("Invalid input. Please enter a number (no fractions): ");
                                            quantityAdd = Console.ReadLine();
                                            Console.WriteLine();
                                        }
                                        Item.Add(resultItem, double.Parse(quantityAdd));
                                        Console.Write($"UPDATE: ");
                                        resultItem.Display();
                                        Console.Write("Are you satisfied with your changes? [Y/N]");
                                        break;
                                    case "D":
                                        Console.Write("Enter how many you want to subtract: ");
                                        quantitySubtract = Console.ReadLine();
                                        Console.WriteLine();

                                        while (!double.TryParse(quantitySubtract, out cleanNum))
                                        {
                                            Console.Write("Invalid input. Please enter a number (no fractions): ");
                                            quantitySubtract = Console.ReadLine();
                                            Console.WriteLine();
                                        }
                                        Item.Subtract(resultItem, double.Parse(quantitySubtract));
                                        resultItem.Display();
                                        Console.Write("Are you satisfied with your changes? [Y/N]");
                                        break;
                                    default:
                                        break;
                                }
                            }
                            while (Console.ReadLine().ToLower() != "y");
                        }
                        else
                        {
                            // Ask the user to type the quantity
                            Console.Write("Quantity: ");
                            quantity = Console.ReadLine();

                            while (!double.TryParse(quantity, out cleanNum))
                            {
                                Console.Write("Invalid input. Please enter a number (no fractions): ");
                                quantity = Console.ReadLine();
                            }

                            // Ask the user for the unit of measure
                            Console.Write("Unit of Measure: ");
                            unitOfMeasure = Console.ReadLine();

                            var newItem = new Item(ingredient, double.Parse(quantity), unitOfMeasure);
                            seafood.Add(ingredient, newItem);
                        }
                        break;
                    case "5":   // Grains_Cereals
                        // Ask the user to type the name of item
                        Console.Write("Enter Item: ");
                        ingredient = Console.ReadLine().ToLower();

                        // Check to see if ingredient is already in this dictionary
                         resultItem = grains_cereals.ContainsKey(ingredient) ? grains_cereals[ingredient] : null;

                        if (resultItem != null)     // if ingredient exists..
                        {
                            do
                            {
                                Console.WriteLine("\t A - Add");
                                Console.WriteLine("\t D - Delete");
                                Console.WriteLine("\t any key - Go to next item");

                                string choice = Console.ReadLine().ToUpper();
                                Console.Clear();
                                switch (choice)
                                {
                                    case "A":
                                        Console.Write("Enter how many you want to add: ");
                                        quantityAdd = Console.ReadLine();
                                        Console.WriteLine();

                                        while (!double.TryParse(quantityAdd, out cleanNum))
                                        {
                                            Console.Write("Invalid input. Please enter a number (no fractions): ");
                                            quantityAdd = Console.ReadLine();
                                            Console.WriteLine();
                                        }
                                        Item.Add(resultItem, double.Parse(quantityAdd));
                                        Console.Write($"UPDATE: ");
                                        resultItem.Display();
                                        Console.Write("Are you satisfied with your changes? [Y/N]");
                                        break;
                                    case "D":
                                        Console.Write("Enter how many you want to subtract: ");
                                        quantitySubtract = Console.ReadLine();
                                        Console.WriteLine();

                                        while (!double.TryParse(quantitySubtract, out cleanNum))
                                        {
                                            Console.Write("Invalid input. Please enter a number (no fractions): ");
                                            quantitySubtract = Console.ReadLine();
                                            Console.WriteLine();
                                        }
                                        Item.Subtract(resultItem, double.Parse(quantitySubtract));
                                        resultItem.Display();
                                        Console.Write("Are you satisfied with your changes? [Y/N]");
                                        break;
                                    default:
                                        break;
                                }
                            }
                            while (Console.ReadLine().ToLower() != "y");
                        }
                        else
                        {
                            // Ask the user to type the quantity
                            Console.Write("Quantity: ");
                            quantity = Console.ReadLine();

                            while (!double.TryParse(quantity, out cleanNum))
                            {
                                Console.Write("Invalid input. Please enter a number (no fractions): ");
                                quantity = Console.ReadLine();
                            }

                            // Ask the user for the unit of measure
                            Console.Write("Unit of Measure: ");
                            unitOfMeasure = Console.ReadLine();

                            var newItem = new Item(ingredient, double.Parse(quantity), unitOfMeasure);
                            grains_cereals.Add(ingredient, newItem);
                        }
                        break;
                    case "6":   // Beverages
                        // Ask the user to type the name of item
                        Console.Write("Enter Item: ");
                        ingredient = Console.ReadLine().ToLower();

                        // Check to see if ingredient is already in this dictionary
                         resultItem = beverages.ContainsKey(ingredient) ? beverages[ingredient] : null;

                        if (resultItem != null)     // if ingredient exists..
                        {
                            do
                            {
                                Console.WriteLine("\t A - Add");
                                Console.WriteLine("\t D - Delete");
                                Console.WriteLine("\t any key - Go to next item");

                                string choice = Console.ReadLine().ToUpper();
                                Console.Clear();
                                switch (choice)
                                {
                                    case "A":
                                        Console.Write("Enter how many you want to add: ");
                                        quantityAdd = Console.ReadLine();
                                        Console.WriteLine();

                                        while (!double.TryParse(quantityAdd, out cleanNum))
                                        {
                                            Console.Write("Invalid input. Please enter a number (no fractions): ");
                                            quantityAdd = Console.ReadLine();
                                            Console.WriteLine();
                                        }
                                        Item.Add(resultItem, double.Parse(quantityAdd));
                                        Console.Write($"UPDATE: ");
                                        resultItem.Display();
                                        Console.Write("Are you satisfied with your changes? [Y/N]");
                                        break;
                                    case "D":
                                        Console.Write("Enter how many you want to subtract: ");
                                        quantitySubtract = Console.ReadLine();
                                        Console.WriteLine();

                                        while (!double.TryParse(quantitySubtract, out cleanNum))
                                        {
                                            Console.Write("Invalid input. Please enter a number (no fractions): ");
                                            quantitySubtract = Console.ReadLine();
                                            Console.WriteLine();
                                        }
                                        Item.Subtract(resultItem, double.Parse(quantitySubtract));
                                        resultItem.Display();
                                        Console.Write("Are you satisfied with your changes? [Y/N]");
                                        break;
                                    default:
                                        break;
                                }
                            }
                            while (Console.ReadLine().ToLower() != "y");
                        }
                        else
                        {
                            // Ask the user to type the quantity
                            Console.Write("Quantity: ");
                            quantity = Console.ReadLine();

                            while (!double.TryParse(quantity, out cleanNum))
                            {
                                Console.Write("Invalid input. Please enter a number (no fractions): ");
                                quantity = Console.ReadLine();
                            }

                            // Ask the user for the unit of measure
                            Console.Write("Unit of Measure: ");
                            unitOfMeasure = Console.ReadLine();

                            var newItem = new Item(ingredient, double.Parse(quantity), unitOfMeasure);
                            beverages.Add(ingredient, newItem);
                        }
                        break;
                    case "7":   // Confections
                        // Ask the user to type the name of item
                        Console.Write("Enter Item: ");
                        ingredient = Console.ReadLine().ToLower();

                        // Check to see if ingredient is already in this dictionary
                         resultItem = confections.ContainsKey(ingredient) ? confections[ingredient] : null;

                        if (resultItem != null)     // if ingredient exists..
                        {
                            do
                            {
                                Console.WriteLine("\t A - Add");
                                Console.WriteLine("\t D - Delete");
                                Console.WriteLine("\t any key - Go to next item");

                                string choice = Console.ReadLine().ToUpper();
                                Console.Clear();
                                switch (choice)
                                {
                                    case "A":
                                        Console.Write("Enter how many you want to add: ");
                                        quantityAdd = Console.ReadLine();
                                        Console.WriteLine();

                                        while (!double.TryParse(quantityAdd, out cleanNum))
                                        {
                                            Console.Write("Invalid input. Please enter a number (no fractions): ");
                                            quantityAdd = Console.ReadLine();
                                            Console.WriteLine();
                                        }
                                        Item.Add(resultItem, double.Parse(quantityAdd));
                                        Console.Write($"UPDATE: ");
                                        resultItem.Display();
                                        Console.Write("Are you satisfied with your changes? [Y/N]");
                                        break;
                                    case "D":
                                        Console.Write("Enter how many you want to subtract: ");
                                        quantitySubtract = Console.ReadLine();
                                        Console.WriteLine();

                                        while (!double.TryParse(quantitySubtract, out cleanNum))
                                        {
                                            Console.Write("Invalid input. Please enter a number (no fractions): ");
                                            quantitySubtract = Console.ReadLine();
                                            Console.WriteLine();
                                        }
                                        Item.Subtract(resultItem, double.Parse(quantitySubtract));
                                        resultItem.Display();
                                        Console.Write("Are you satisfied with your changes? [Y/N]");
                                        break;
                                    default:
                                        break;
                                }
                            }
                            while (Console.ReadLine().ToLower() != "y");
                        }
                        else
                        {
                            // Ask the user to type the quantity
                            Console.Write("Quantity: ");
                            quantity = Console.ReadLine();

                            while (!double.TryParse(quantity, out cleanNum))
                            {
                                Console.Write("Invalid input. Please enter a number (no fractions): ");
                                quantity = Console.ReadLine();
                            }

                            // Ask the user for the unit of measure
                            Console.Write("Unit of Measure: ");
                            unitOfMeasure = Console.ReadLine();

                            var newItem = new Item(ingredient, double.Parse(quantity), unitOfMeasure);
                            confections.Add(ingredient, newItem);
                        }
                        break;
                    case "8":   // Dairy_Products
                        // Ask the user to type the name of item
                        Console.Write("Enter Item: ");
                        ingredient = Console.ReadLine().ToLower();

                        // Check to see if ingredient is already in this dictionary
                         resultItem = dairy_products.ContainsKey(ingredient) ? dairy_products[ingredient] : null;

                        if (resultItem != null)     // if ingredient exists..
                        {
                            do
                            {
                                Console.WriteLine("\t A - Add");
                                Console.WriteLine("\t D - Delete");
                                Console.WriteLine("\t any key - Go to next item");

                                string choice = Console.ReadLine().ToUpper();
                                Console.Clear();
                                switch (choice)
                                {
                                    case "A":
                                        Console.Write("Enter how many you want to add: ");
                                        quantityAdd = Console.ReadLine();
                                        Console.WriteLine();

                                        while (!double.TryParse(quantityAdd, out cleanNum))
                                        {
                                            Console.Write("Invalid input. Please enter a number (no fractions): ");
                                            quantityAdd = Console.ReadLine();
                                            Console.WriteLine();
                                        }
                                        Item.Add(resultItem, double.Parse(quantityAdd));
                                        Console.Write($"UPDATE: ");
                                        resultItem.Display();
                                        Console.Write("Are you satisfied with your changes? [Y/N]");
                                        break;
                                    case "D":
                                        Console.Write("Enter how many you want to subtract: ");
                                        quantitySubtract = Console.ReadLine();
                                        Console.WriteLine();

                                        while (!double.TryParse(quantitySubtract, out cleanNum))
                                        {
                                            Console.Write("Invalid input. Please enter a number (no fractions): ");
                                            quantitySubtract = Console.ReadLine();
                                            Console.WriteLine();
                                        }
                                        Item.Subtract(resultItem, double.Parse(quantitySubtract));
                                        resultItem.Display();
                                        Console.Write("Are you satisfied with your changes? [Y/N]");
                                        break;
                                    default:
                                        break;
                                }
                            }
                            while (Console.ReadLine().ToLower() != "y");
                        }
                        else
                        {
                            // Ask the user to type the quantity
                            Console.Write("Quantity: ");
                            quantity = Console.ReadLine();

                            while (!double.TryParse(quantity, out cleanNum))
                            {
                                Console.Write("Invalid input. Please enter a number (no fractions): ");
                                quantity = Console.ReadLine();
                            }

                            // Ask the user for the unit of measure
                            Console.Write("Unit of Measure: ");
                            unitOfMeasure = Console.ReadLine();

                            var newItem = new Item(ingredient, double.Parse(quantity), unitOfMeasure);
                            dairy_products.Add(ingredient, newItem);
                        }
                        break;
                    case "9":   // Others
                        // Ask the user to type the name of item
                        Console.Write("Enter Item: ");
                        ingredient = Console.ReadLine().ToLower();

                        // Check to see if ingredient is already in this dictionary
                         resultItem = others.ContainsKey(ingredient) ? others[ingredient] : null;

                        if (resultItem != null)     // if ingredient exists..
                        {
                            do
                            {
                                Console.WriteLine("\t A - Add");
                                Console.WriteLine("\t D - Delete");
                                Console.WriteLine("\t any key - Go to next item");

                                string choice = Console.ReadLine().ToUpper();
                                Console.Clear();
                                switch (choice)
                                {
                                    case "A":
                                        Console.Write("Enter how many you want to add: ");
                                        quantityAdd = Console.ReadLine();
                                        Console.WriteLine();

                                        while (!double.TryParse(quantityAdd, out cleanNum))
                                        {
                                            Console.Write("Invalid input. Please enter a number (no fractions): ");
                                            quantityAdd = Console.ReadLine();
                                            Console.WriteLine();
                                        }
                                        Item.Add(resultItem, double.Parse(quantityAdd));
                                        Console.Write($"UPDATE: ");
                                        resultItem.Display();
                                        Console.Write("Are you satisfied with your changes? [Y/N]");
                                        break;
                                    case "D":
                                        Console.Write("Enter how many you want to subtract: ");
                                        quantitySubtract = Console.ReadLine();
                                        Console.WriteLine();

                                        while (!double.TryParse(quantitySubtract, out cleanNum))
                                        {
                                            Console.Write("Invalid input. Please enter a number (no fractions): ");
                                            quantitySubtract = Console.ReadLine();
                                            Console.WriteLine();
                                        }
                                        Item.Subtract(resultItem, double.Parse(quantitySubtract));
                                        resultItem.Display();
                                        Console.Write("Are you satisfied with your changes? [Y/N]");
                                        break;
                                    default:
                                        break;
                                }
                            }
                            while (Console.ReadLine().ToLower() != "y");
                        }
                        else
                        {
                            // Ask the user to type the quantity
                            Console.Write("Quantity: ");
                            quantity = Console.ReadLine();

                            while (!double.TryParse(quantity, out cleanNum))
                            {
                                Console.Write("Invalid input. Please enter a number (no fractions): ");
                                quantity = Console.ReadLine();
                            }

                            // Ask the user for the unit of measure
                            Console.Write("Unit of Measure: ");
                            unitOfMeasure = Console.ReadLine();

                            var newItem = new Item(ingredient, double.Parse(quantity), unitOfMeasure);
                            others.Add(ingredient, newItem);
                        }
                        break;
                    default:
                        Console.Clear();
                        Console.Write("Do you want to review your list before continuing? [Y/N] ");
                        if (Console.ReadLine().ToLower() == "y")
                        {
                            Console.WriteLine();
                            for (int i = 0; i < Categories.Length; i++)
                            {
                                foreach (KeyValuePair<string, Item> kvp in Categories[i])
                                {
                                    Console.WriteLine($"{kvp.Value.Quantity}x {kvp.Value.UnitOfMeasure} | {kvp.Value.Ingredient}");
                                }
                            }
                        }
                        Console.Write("\nDo you want to modify any items? [Y/N]");
                        if ((Console.ReadLine()).ToLower() == "y")
                            endApp = false;
                        else
                            endApp = true;
                        break;
                }

            }
            Console.Clear();

            // FUTURE PLANS:  ALLOW USER TO PRINT SPECIFIC CATEGORIES TO NEW FILE

            using (StreamWriter sw = new StreamWriter("ShoppingList.txt"))
            {
                sw.WriteLine($"Shopping List         {DateTime.Today}");
                sw.WriteLine();

                endApp = false;
                while (!endApp)
                {
                    Console.Clear();

                    // user decides what items to print to a file
                    Console.WriteLine("What categories do you want to print to file?");
                    Console.WriteLine("\t1 - Produce");
                    Console.WriteLine("\t2 - Condiments");
                    Console.WriteLine("\t3 - Meat/Poultry");
                    Console.WriteLine("\t4 - Seafood");
                    Console.WriteLine("\t5 - Grains/Cereals");
                    Console.WriteLine("\t6 - Beverages");
                    Console.WriteLine("\t7 - Confections");
                    Console.WriteLine("\t8 - Dairy Products");
                    Console.WriteLine("\t9 - Other");
                    Console.WriteLine("\tC - Complete with selection");
                    Console.WriteLine("\tany other key - Print ALL and close\n");

                    switch (Console.ReadLine().ToUpper())
                    {
                        case "1":   // Print only Produce
                            foreach (KeyValuePair<string, Item> kvp in Categories[0])
                            {
                                sw.WriteLine($"{kvp.Value.Quantity}x {kvp.Value.UnitOfMeasure} | {kvp.Value.Ingredient}");
                            }
                            break;
                        case "2":   // Print only Condiments
                            foreach (KeyValuePair<string, Item> kvp in Categories[1])
                            {
                                sw.WriteLine($"{kvp.Value.Quantity}x {kvp.Value.UnitOfMeasure} | {kvp.Value.Ingredient}");
                            }
                            break;
                        case "3":   // Print only Meat/Poultry
                            foreach (KeyValuePair<string, Item> kvp in Categories[2])
                            {
                                sw.WriteLine($"{kvp.Value.Quantity}x {kvp.Value.UnitOfMeasure} | {kvp.Value.Ingredient}");
                            }
                            break;
                        case "4":   // Print only Seafood
                            foreach (KeyValuePair<string, Item> kvp in Categories[3])
                            {
                                sw.WriteLine($"{kvp.Value.Quantity}x {kvp.Value.UnitOfMeasure} | {kvp.Value.Ingredient}");
                            }
                            break;
                        case "5":   // Print only Grains/Cereals
                            foreach (KeyValuePair<string, Item> kvp in Categories[4])
                            {
                                sw.WriteLine($"{kvp.Value.Quantity}x {kvp.Value.UnitOfMeasure} | {kvp.Value.Ingredient}");
                            }
                            break;
                        case "6":   // Print only Beverages
                            foreach (KeyValuePair<string, Item> kvp in Categories[5])
                            {
                                sw.WriteLine($"{kvp.Value.Quantity}x {kvp.Value.UnitOfMeasure} | {kvp.Value.Ingredient}");
                            }
                            break;
                        case "7":   // Print only Confections
                            foreach (KeyValuePair<string, Item> kvp in Categories[6])
                            {
                                sw.WriteLine($"{kvp.Value.Quantity}x {kvp.Value.UnitOfMeasure} | {kvp.Value.Ingredient}");
                            }
                            break;
                        case "8":   // Print only Dairy Products
                            foreach (KeyValuePair<string, Item> kvp in Categories[7])
                            {
                                sw.WriteLine($"{kvp.Value.Quantity}x {kvp.Value.UnitOfMeasure} | {kvp.Value.Ingredient}");
                            }
                            break;
                        case "9":   // Print only Other
                            foreach (KeyValuePair<string, Item> kvp in Categories[8])
                            {
                                sw.WriteLine($"{kvp.Value.Quantity}x {kvp.Value.UnitOfMeasure} | {kvp.Value.Ingredient}");
                            }
                            break;
                        case "C":   // Print only Other
                            endApp = true;
                            break;
                        default:        // Print ALL and close
                            for (int i = 0; i < Categories.Length; i++)
                            {
                                foreach (KeyValuePair<string, Item> kvp in Categories[i])
                                {
                                    sw.WriteLine($"{kvp.Value.Quantity}x {kvp.Value.UnitOfMeasure} | {kvp.Value.Ingredient}");
                                }
                            }
                            endApp = true;
                            break;
                    }
                }
            }
        }
    }
}
