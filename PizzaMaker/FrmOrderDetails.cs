using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PizzaMakerClassLibrary.Models;
using PizzaMakerClassLibrary.Services.BusinessLogicLayer;

/*
 * Christopher Zion
 * CST-250
 * 02/07/2026
 * Pizza Maker
 * Activity 4
 */

namespace PizzaMaker
{
    public partial class FrmOrderDetails : Form
    {
        // Declare class level variables
        private List<PizzaModel> _pizzaOrders;
        private PizzaLogic _pizzaLogic;

        /// <summary>
        /// Default constructor for FrmOrderDetails
        /// </summary>
        public FrmOrderDetails()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Parameterized constructor for FrmOrderDetails
        /// </summary>
        /// <param name="pizzaOrderList"></param>
        /// <param name="pizzaBusinessLogic"></param>
        public FrmOrderDetails(List<PizzaModel> pizzaOrderList, PizzaLogic pizzaBusinessLogic)
        {
            // Initialize the form
            InitializeComponent();
            // Initialize the class level variables
            _pizzaOrder = pizzaOrderList;
            _pizzaLogic = pizzaBusinessLogic;
            // Display the pizzas on the form
            DisplayPizzas();
        }

        // Correct variable name to match guide which used _pizzaOrder or _pizzaOrders. Guide used _pizzaOrder in DAO and _pizzaOrders (plural? logic?)
        // In the guide screenshot 106, it used private List<PizzaModel> _pizzaOrders;
        // In screenshot 107 constructor, it used _pizzaOrder = pizzaOrderList;
        // I will use _pizzaOrder to be consistent with the logic inside the method.
        private List<PizzaModel> _pizzaOrder;

        /// <summary>
        /// Display the pizzas on the form
        /// </summary>
        public void DisplayPizzas()
        {
            // Clear the label
            lblOrderDetails.Text = "";
            // Loop through the pizza order list
            foreach (PizzaModel pizza in _pizzaOrder)
            {
                lblOrderDetails.Text +=
                    $"Name: {pizza.ClientName}\n" +
                    $"Ingredients: {string.Join(", ", pizza.Ingredients)}\n" +
                    $"Strange Add Ons: {string.Join(", ", pizza.StrangeAddOns)}\n" +
                    $"Crust: {pizza.Crust}\n" +
                    $"Sauce: {pizza.SauceQty}\n" +
                    $"Cheese: {pizza.CheeseQty}\n" +
                    $"Delivery Time: {pizza.DeliveryTime}\n" +
                    $"Pizza Box Color: {pizza.PizzaBoxColor}\n" +
                    $"Price: {pizza.Price:C2}\n\n";
            }
        }

        /// <summary>
        /// Click event handler for btnSaveOrder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSaveOrderClickEH(object sender, EventArgs e)
        {
            // Declare and initialize
            bool isSaveSuccess = false;
            // Write the order to the file
            isSaveSuccess = _pizzaLogic.WriteOrderToFile();
            // Check if the save was successful
            if (isSaveSuccess)
            {
                // Show a success message to the user
                MessageBox.Show("The pizza order was saved.");
            }
            else
            {
                // Show a failure message to the user
                MessageBox.Show("An error occurred while trying to save your order. Please try again later.");
            }
        }

        /// <summary>
        /// Click event handler for btnBack
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBackClickEH(object sender, EventArgs e)
        {
            // Challenge 2: Back Button
            // Close the current form to return to the parent form (ShowDialog parent)
            this.Close();
        }
    }
}
