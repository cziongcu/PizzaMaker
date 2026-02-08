using System;
using System.Collections.Generic;
using System.IO;
using PizzaMakerClassLibrary.Models;

/*
 * Christopher Zion
 * CST-250
 * 02/07/2026
 * Pizza Maker
 * Activity 4
 */

namespace PizzaMakerClassLibrary.Services.DataAccessLayer
{
    public class PizzaDAO
    {
        // Class level variables
        private List<PizzaModel> _pizzaOrder;

        /// <summary>
        /// Default constructor for the pizza DAO
        /// </summary>
        public PizzaDAO()
        {
            // Initialize the _pizzaOrder list
            _pizzaOrder = new List<PizzaModel>();
        }

        /// <summary>
        /// Add a pizza to the current order
        /// </summary>
        /// <param name="newPizza">The new pizza model to add</param>
        /// <returns>The number of pizzas in the current order</returns>
        public int AddPizzaToOrder(PizzaModel newPizza)
        {
            // Add the new pizza to the pizzaOrder list
            _pizzaOrder.Add(newPizza);
            // Return the number of pizzas in pizzaOrder
            return _pizzaOrder.Count;
        }

        /// <summary>
        /// Get the list of pizzas in the current order
        /// </summary>
        /// <returns>List of PizzaModel objects</returns>
        public List<PizzaModel> GetPizzaOrder()
        {
            return _pizzaOrder;
        }

        /// <summary>
        /// Write the pizza order to a text file
        /// </summary>
        /// <returns>True if successful, false otherwise</returns>
        public bool WriteOrderToFile()
        {
            // Declare and initialize
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data");
            string pizzaString = "";

            // Check if the directory exists
            if (!Directory.Exists(filePath))
            {
                // Create the directory
                Directory.CreateDirectory(filePath);
            }

            // Set up a try-catch for the file writer
            try
            {
                // Create a using statement for StreamWriter
                using (StreamWriter streamWriter = new StreamWriter(Path.Combine(filePath, "PizzaOrder.txt")))
                {
                    // Loop through the pizza order list
                    foreach (PizzaModel pizza in _pizzaOrder)
                    {
                        pizzaString =
                            $"Name: {pizza.ClientName}\n" +
                            $"Ingredients: {string.Join(", ", pizza.Ingredients)}\n" +
                            $"Strange Add Ons: {string.Join(", ", pizza.StrangeAddOns)}\n" +
                            $"Crust: {pizza.Crust}\n" +
                            $"Sauce: {pizza.SauceQty}\n" +
                            $"Cheese: {pizza.CheeseQty}\n" +
                            $"Delivery Time: {pizza.DeliveryTime}\n" +
                            $"Pizza Box Color: {pizza.PizzaBoxColor}\n" +
                            $"Price: {pizza.Price:C2}\n"; // Formatting price as currency
                        streamWriter.WriteLine(pizzaString);
                    }
                }
                // Return true
                return true;
            }
            catch
            {
                // Return false
                return false;
            }
        }
    }
}
