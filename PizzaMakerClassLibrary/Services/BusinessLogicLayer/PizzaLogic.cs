using PizzaMakerClassLibrary.Models;
using PizzaMakerClassLibrary.Services.DataAccessLayer;

/*
 * Christopher Zion
 * CST-250
 * 02/07/2026
 * Pizza Maker
 * Activity 4
 */

namespace PizzaMakerClassLibrary.Services.BusinessLogicLayer
{
    public class PizzaLogic
    {
        // Declare class level variables
        private PizzaDAO _pizzaDAO;

        /// <summary>
        /// Default constructor for PizzaLogic
        /// </summary>
        public PizzaLogic()
        {
            // Initialize the pizza DAO object
            _pizzaDAO = new PizzaDAO();
        }

        /// <summary>
        /// Add a new pizza to the current order
        /// </summary>
        /// <param name="newPizza">The new pizza model to add</param>
        /// <returns>A boolean for if the pizza is valid and the count of pizzas in order</returns>
        public (bool isValidPizza, int pizzasInOrder) AddPizzaToOrder(PizzaModel newPizza)
        {
            // Challenge 1: Pizza Validation
            // A valid pizza has a name, a crust selection, at least one ingredient, and values greater than 0 for cheese and sauce.
            // Note: The guide says "Add logic to the DAO to add a new pizza" then "Update AddPizzaToOrder method in PizzaLogic to make sure pizzas passed in are valid"
            
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(newPizza.ClientName) || newPizza.ClientName == "Unknown") isValid = false;
            if (string.IsNullOrWhiteSpace(newPizza.Crust) || newPizza.Crust == "Unknown") isValid = false;
            if (newPizza.Ingredients == null || newPizza.Ingredients.Count == 0) isValid = false;
            if (newPizza.SauceQty <= 0) isValid = false;
            if (newPizza.CheeseQty <= 0) isValid = false;

            if (!isValid)
            {
                return (false, -1);
            }

            // Declare and initialize
            int pizzas = -1;

            // Call the DAO AddPizzaToOrder
            pizzas = _pizzaDAO.AddPizzaToOrder(newPizza);
            // Return the pizzas variable
            return (true, pizzas);
        }

        /// <summary>
        /// Get the list of pizzas in the current order
        /// </summary>
        /// <returns>List of PizzaModel objects</returns>
        public List<PizzaModel> GetPizzaOrder()
        {
            // Get and return GetPizzaOrder from the DAO
            return _pizzaDAO.GetPizzaOrder();
        }

        /// <summary>
        /// Write the pizza order to a text file
        /// </summary>
        /// <returns>True if successful, false otherwise</returns>
        public bool WriteOrderToFile()
        {
            // Get and return WriteOrderToFile from the DAO
            return _pizzaDAO.WriteOrderToFile();
        }
    }
}
