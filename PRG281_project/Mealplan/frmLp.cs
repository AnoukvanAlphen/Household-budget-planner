using Goals_PRG281_project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PROJECTPAIN
{
    public partial class frmLinprog : Form
    {
        Navigation navigation = new Navigation();
        List<FoodItem> foodItems = new List<FoodItem>
        {
            new FoodItem("Apple", 2.1, 52, 0.3, 14, 0.2), // R2.1 per unit
            new FoodItem("Banana", 1.4, 89, 1.1, 23, 0.3), // R1.4 per unit
            new FoodItem("Orange", 2.8, 47, 0.9, 12, 0.1), // R2.8 per unit
            new FoodItem("Strawberries", 1.4, 32, 0.7, 7.7, 0.3), // R1.4 per unit
            new FoodItem("Blueberries", 2.1, 57, 0.7, 14, 0.3), // R2.1 per unit
            new FoodItem("Pineapple", 4.2, 50, 0.5, 13, 0.1), // R4.2 per unit
            new FoodItem("Avocado", 7.0, 160, 2.0, 9, 15), // R7.0 per unit
            new FoodItem("Pear", 2.8, 39, 0.4, 10, 0.1), // R2.8 per unit
            new FoodItem("Grapes", 3.5, 69, 0.7, 18, 0.2), // R3.5 per unit
            new FoodItem("Mango", 4.9, 60, 0.8, 15, 0.4), // R4.9 per unit
            new FoodItem("Kiwi", 3.5, 61, 1.1, 15, 0.5), // R3.5 per unit
            new FoodItem("Peach", 2.8, 39, 0.9, 10, 0.3), // R2.8 per unit
            new FoodItem("Plum", 3.5, 46, 0.7, 11, 0.3), // R3.5 per unit
            new FoodItem("Cherries", 4.2, 50, 1.0, 12, 0.3), // R4.2 per unit
            new FoodItem("Raspberries", 7.0, 52, 1.2, 12, 0.7), // R7.0 per unit
            new FoodItem("Watermelon", 4.2, 30, 0.6, 8, 0.2), // R4.2 per unit
            new FoodItem("Pomegranate", 4.9, 83, 1.7, 19, 1.2), // R4.9 per unit
            new FoodItem("Grapefruit", 2.1, 42, 0.8, 11, 0.1), // R2.1 per unit
            new FoodItem("Apricot", 2.8, 48, 0.5, 12, 0.1), // R2.8 per unit
            new FoodItem("Nectarine", 2.1, 44, 0.6, 11, 0.2), // R2.1 per unit
            new FoodItem("Plumcot", 2.8, 50, 0.7, 13, 0.2), // R2.8 per unit
            new FoodItem("Persimmon", 4.2, 81, 0.6, 21, 0.3), // R4.2 per unit
            new FoodItem("Blackberry", 3.5, 43, 1.4, 10, 0.5), // R3.5 per unit
            new FoodItem("Gooseberry", 4.9, 44, 0.6, 10, 0.2), // R4.9 per unit
            new FoodItem("Mulberry", 4.2, 43, 1.4, 10, 0.4), // R4.2 per unit
            new FoodItem("Fig", 4.2, 74, 0.8, 19, 0.3), // R4.2 per unit
            new FoodItem("Date", 7.0, 277, 1.8, 75, 0.2), // R7.0 per unit
            new FoodItem("Rhubarb", 2.1, 21, 0.9, 5, 0.1), // R2.1 per unit
            new FoodItem("Coconut", 4.9, 354, 3.3, 15, 33.5), // R4.9 per unit
            new FoodItem("Cantaloupe", 2.1, 34, 0.8, 8, 0.2), // R2.1 per unit
             new FoodItem("Honeydew", 2.8, 36, 0.5, 9, 0.1), // R2.8 per unit
            new FoodItem("Jackfruit", 4.2, 95, 1.7, 24, 0.6), // R4.2 per unit
            new FoodItem("Papaya", 4.2, 43, 0.5, 11, 0.3), // R4.2 per unit
            new FoodItem("Starfruit", 2.8, 31, 1.0, 7, 0.3), // R2.8 per unit
            new FoodItem("Dragonfruit", 4.9, 60, 1.2, 13, 0.6), // R4.9 per unit
            new FoodItem("Kiwi Berry", 3.5, 61, 1.0, 15, 0.5), // R3.5 per unit
            new FoodItem("Lime", 1.4, 30, 0.7, 7, 0.3), // R1.4 per unit
            new FoodItem("Lemon", 2.8, 29, 1.1, 9, 0.3), // R2.8 per unit
            new FoodItem("Tangerine", 2.1, 53, 0.8, 13, 0.2), // R2.1 per unit
            new FoodItem("Mandarin", 2.8, 53, 0.8, 13, 0.2), // R2.8 per unit
            new FoodItem("Clementine", 2.1, 47, 0.8, 12, 0.1), // R2.1 per unit
            new FoodItem("Soursop", 4.9, 66, 1.0, 16, 0.3), // R4.9 per unit
            new FoodItem("Durian", 7.0, 147, 1.5, 27, 5.3), // R7.0 per unit
            new FoodItem("Pomelo", 4.9, 38, 0.8, 10, 0.2), // R4.9 per unit
            new FoodItem("Date Plum", 4.2, 77, 1.0, 19, 0.2), // R4.2 per unit
            new FoodItem("Quince", 4.2, 57, 0.2, 15, 0.1), // R4.2 per unit
            new FoodItem("Feijoa", 4.9, 55, 0.7, 14, 0.3), // R4.9 per unit
            new FoodItem("Passionfruit", 4.2, 97, 2.2, 23, 0.4), // R4.2 per unit
            new FoodItem("Pawpaw", 4.2, 59, 0.5, 15, 0.3), // R4.2 per unit
            new FoodItem("Mangosteen", 4.9, 73, 0.6, 17, 0.3), // R4.9 per unit
            new FoodItem("Longan", 4.9, 60, 1.3, 16, 0.1), // R4.9 per unit
            new FoodItem("Salak", 4.2, 82, 0.7, 22, 0.4), // R4.2 per unit
            new FoodItem("Jujube", 4.9, 79, 1.2, 21, 0.1), // R4.9 per unit
            new FoodItem("Cranberry", 4.2, 46, 0.4, 12, 0.1), // R4.2 per unit
            new FoodItem("Elderberry", 4.2, 73, 1.0, 18, 0.5), // R4.2 per unit
            new FoodItem("Goji Berry", 4.9, 82, 8.0, 45, 0.5), // R4.9 per unit
            new FoodItem("Grapes (Red)", 3.5, 69, 0.7, 18, 0.2), // R3.5 per unit
            new FoodItem("Grapes (Green)", 3.5, 69, 0.7, 18, 0.2), // R3.5 per unit
            new FoodItem("Tamarind", 4.2, 239, 2.8, 63, 0.7), // R4.2 per unit
            new FoodItem("Bael Fruit", 4.9, 84, 1.1, 22, 0.2), // R4.9 per unit
            new FoodItem("Sapodilla", 4.9, 83, 0.7, 19, 0.8), // R4.9 per unit
            new FoodItem("Cherimoya", 4.2, 75, 1.5, 19, 0.3), // R4.2 per unit
            new FoodItem("Açaí Berry", 4.9, 70, 1.0, 4, 4.0), // R4.9 per unit
            new FoodItem("Cactus Pear", 4.2, 50, 1.0, 13, 0.2), // R4.2 per unit
            new FoodItem("Soursop (Graviola)", 4.9, 66, 1.0, 16, 0.3), // R4.9 per unit
            new FoodItem("Miracle Fruit", 4.2, 60, 0.5, 15, 0.3), // R4.2 per unit
            new FoodItem("Apple Pear", 2.8, 39, 0.4, 10, 0.1), // R2.8 per unit
            new FoodItem("African Horned Cucumber", 4.2, 44, 0.8, 11, 0.3), // R4.2 per unit
            new FoodItem("Salmon", 22.1, 206, 22.5, 0, 12.0), // R22.1 per 100g
            new FoodItem("Chicken Breast", 14.0, 165, 31.0, 0, 3.6), // R14.0 per 100g
            new FoodItem("Beef Steak", 15.2, 250, 26.0, 0, 10.0), // R15.2 per 100g
            new FoodItem("Pork Chop", 16.3, 231, 21.0, 0, 11.0), // R16.3 per 100g
            new FoodItem("Turkey Breast", 13.0, 135, 30.0, 0, 1.0), // R13.0 per 100g
            new FoodItem("Lamb Chop", 18.5, 282, 25.0, 0, 21.0), // R18.5 per 100g
            new FoodItem("Cod", 17.0, 82, 18.0, 0, 0.5), // R17.0 per 100g
            new FoodItem("Tuna", 18.0, 132, 28.0, 0, 0.5), // R18.0 per 100g
            new FoodItem("Shrimp", 23.5, 99, 24.0, 0, 0.5), // R23.5 per 100g
            new FoodItem("Mussels", 19.2, 172, 24.0, 5, 1.0), // R19.2 per 100g
            new FoodItem("Squid", 18.0, 92, 15.0, 0, 1.0), // R18.0 per 100g
            new FoodItem("Clams", 20.0, 148, 25.0, 3, 1.0), // R20.0 per 100g
            new FoodItem("Lentils", 6.8, 116, 9.0, 20, 0.6), // R6.8 per 100g
            new FoodItem("Chickpeas", 7.0, 164, 8.9, 27, 2.6), // R7.0 per 100g
            new FoodItem("Black Beans", 7.5, 339, 21.0, 62, 0.5), // R7.5 per 100g
            new FoodItem("Kidney Beans", 8.2, 127, 8.7, 22, 0.5), // R8.2 per 100g
            new FoodItem("Pinto Beans", 7.5, 143, 9.0, 27, 0.4), // R7.5 per 100g
            new FoodItem("Navy Beans", 7.8, 140, 8.0, 24, 0.5), // R7.8 per 100g
            new FoodItem("Peas", 5.0, 81, 5.4, 14, 0.4), // R5.0 per 100g
            new FoodItem("Soybeans", 8.5, 173, 16.6, 9, 7.0), // R8.5 per 100g
            new FoodItem("Tofu", 7.8, 76, 8.1, 1.9, 4.8), // R7.8 per 100g
            new FoodItem("Tempeh", 9.0, 192, 20.0, 9, 6.0), // R9.0 per 100g
            new FoodItem("Edamame", 8.5, 121, 11.0, 10, 5.0), // R8.5 per 100g
            new FoodItem("Quinoa", 7.2, 120, 4.1, 21, 1.9), // R7.2 per 100g
            new FoodItem("Oats", 5.5, 389, 16.9, 66, 6.9), // R5.5 per 100g
            new FoodItem("Brown Rice", 6.0, 123, 2.7, 25, 1.0), // R6.0 per 100g
            new FoodItem("White Rice", 5.0, 130, 2.7, 28, 0.3), // R5.0 per 100g
            new FoodItem("Barley", 6.2, 354, 12.5, 73, 1.2), // R6.2 per 100g
            new FoodItem("Millet", 7.0, 378, 11.0, 73, 4.0), // R7.0 per 100g
            new FoodItem("Rye", 7.5, 338, 9.5, 73, 1.0), // R7.5 per 100g
            new FoodItem("Buckwheat", 7.2, 343, 13.3, 71, 3.4), // R7.2 per 100g
            new FoodItem("Cornmeal", 6.5, 365, 8.1, 73, 1.4), // R6.5 per 100g
            new FoodItem("Farro", 7.0, 337, 14.0, 70, 2.0), // R7.0 per 100g
            new FoodItem("Chia Seeds", 9.0, 486, 16.5, 42, 31.0), // R9.0 per 100g
            new FoodItem("Flaxseeds", 8.5, 534, 18.3, 29, 42.0), // R8.5 per 100g
            new FoodItem("Pumpkin Seeds", 8.2, 446, 19.0, 54, 19.0), // R8.2 per 100g
            new FoodItem("Sunflower Seeds", 7.5, 584, 21.0, 20, 51.0), // R7.5 per 100g
            new FoodItem("Sesame Seeds", 7.8, 573, 18.7, 25, 50.0), // R7.8 per 100g
            new FoodItem("Walnuts", 12.0, 654, 15.0, 14, 65.0), // R12.0 per 100g
            new FoodItem("Almonds", 11.5, 579, 21.0, 22, 49.0), // R11.5 per 100g
            new FoodItem("Cashews", 10.5, 553, 18.0, 30, 44.0), // R10.5 per 100g
            new FoodItem("Pecans", 12.0, 691, 9.2, 14, 72.0), // R12.0 per 100g
            new FoodItem("Hazelnuts", 11.0, 628, 14.0, 17, 60.0), // R11.0 per 100g
            new FoodItem("Macadamia Nuts", 14.0, 718, 8.0, 14, 76.0), // R14.0 per 100g
            new FoodItem("Pistachios", 11.0, 562, 20.0, 28, 45.0), // R11.0 per 100g
            new FoodItem("Brazil Nuts", 12.0, 659, 14.0, 12, 66.0), // R12.0 per 100g
            new FoodItem("Peanuts", 60.8, 567, 25.0, 16, 49.0), // R6.8 per 100g
            new FoodItem("Tuna (Canned)", 9.0, 132, 28.0, 0, 0.5), // R9.0 per 100g
            new FoodItem("Salmon (Canned)", 15.0, 206, 22.5, 0, 12.0) // R15.0 per 100g

            // Add more food items as needed
        };
        private void OnMouseEnterbtnLp(object sender, EventArgs e)
        {
            btnLp.BackColor = SystemColors.ButtonHighlight; // or Color.Red or whatever you want
        }
        private void OnMouseLeavebtnLp(object sender, EventArgs e)
        {
            btnLp.BackColor = SystemColors.ButtonFace;
        }
        public frmLinprog()
        {
            InitializeComponent();
            btnLp.MouseEnter += OnMouseEnterbtnLp;
            btnLp.MouseLeave += OnMouseLeavebtnLp;
            this.StartPosition = FormStartPosition.CenterScreen;
           
        }

        private void frmLp_Load(object sender, EventArgs e)
        {
            {
                
            }

            
        }

        private void btnLp_Click(object sender, EventArgs e)
        {
            double calories = 0;
            double protein = 0;
            double carbs = 0;
            double fat = 0;

            // Error handling for parsing
            try
            {
                calories = double.Parse(txtCalorie.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for calories.");
                return; // Exit the method or handle the error appropriately
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number for calories is too large.");
                return; // Exit the method or handle the error appropriately
            }

            try
            {
                protein = double.Parse(txtProtein.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for protein.");
                return; // Exit the method or handle the error appropriately
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number for protein is too large.");
                return; // Exit the method or handle the error appropriately
            }

            try
            {
                carbs = double.Parse(txtCarbohydrate.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for carbohydrates.");
                return; // Exit the method or handle the error appropriately
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number for carbohydrates is too large.");
                return; // Exit the method or handle the error appropriately
            }

            try
            {
                fat = double.Parse(txtFat.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for fat.");
                return; // Exit the method or handle the error appropriately
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number for fat is too large.");
                return; // Exit the method or handle the error appropriately
            }
            rtxtDisplay.Clear();

           
            // Proceed with creating and solving the meal plan
            MealPlan mealPlan = new MealPlan(foodItems, calories, protein, carbs, fat, rtxtDisplay);
            if (mealPlan != null)
            {
                mealPlan.MealPlanSolved -= MealPlan_MealPlanSolved;
            }
            mealPlan.Solve();
            mealPlan.MealPlanSolved += MealPlan_MealPlanSolved;
        }

        private void lblDetailedExpenses_Click(object sender, EventArgs e)
        {

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                navigation.GotoMainMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while navigating to the main menu: " + ex.Message);
            }
        }

        private void llblMainMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                this.Hide();
                navigation.GotoMainMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while navigating to the main menu: " + ex.Message);
            }
        }

        private void picBackground_Click(object sender, EventArgs e)
        {

        }

        private void frmLinprog_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                this.Hide();
                navigation.GotoMainMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while navigating to the main menu: " + ex.Message);
            }
        }
        private void MealPlan_MealPlanSolved(object sender, EventArgs e)
        {
            MessageBox.Show("Meal plan has been solved!");
        }
    }
}
