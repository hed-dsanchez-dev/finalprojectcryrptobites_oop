using System;
using System.Windows.Forms;

namespace CryptoBites_FinalProject
{
    public partial class Foods : Form
    {
        private Cart cart;       // reference to Cart
        private string username; // logged-in username

        public Foods(Cart currentCart, string loggedInUser)
        {
            InitializeComponent();
            cart = currentCart;
            username = loggedInUser;
        }

        // ---------------- Navigation ----------------

        // Back to Cart
        private void btnBack_Click(object sender, EventArgs e)
        {
            cart.Show();
            this.Close();
        }

        // Open Drinks form
       

        // ---------------- Account / About ----------------

        // Account button → show welcome message
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Welcome to CryptoBites, {username}!", "Account Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // About Us button
       

        // ---------------- Add Food Items ----------------
        private void btnAddBurger_Click(object sender, EventArgs e)
        {
            // Example: numericUpDown for quantity
            int quantity = (int)numericUpDownBurger.Value;
            cart.AddItemToCart("Crypto Burger", 129.00m, quantity);
        }

        private void btnAddFries_Click(object sender, EventArgs e)
        {
            int quantity = (int)numericUpDownFries.Value;
            cart.AddItemToCart("Blockchain Fries", 89.00m, quantity);
        }

        private void btnAddSatoshiChicken_Click(object sender, EventArgs e)
        {
            int quantity = (int)numericUpDownChicken.Value;
            cart.AddItemToCart("Satoshi Chicken", 149.00m, quantity);
        }

        private void Foods_Load(object sender, EventArgs e)
        {
            // Optional: initialize default quantities
            numericUpDownBurger.Value = 1;
            numericUpDownFries.Value = 1;
            numericUpDownChicken.Value = 1;
        }

        private void btndrinks_Click_1(object sender, EventArgs e)
        {
            // Create a Foods form passing the same Cart and username
            Dinks drinksform = new Dinks(cart, username);
            drinksform.Show();

            // Hide the current Dinks form
            this.Hide();
        }

        private void btnfood_Click(object sender, EventArgs e)
        {
            Foods Foodsform = new Foods(cart, username);
            Foodsform.Show();

            // Hide the current Dinks form
            this.Hide();
            MessageBox.Show("Please select Food.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            string aboutText =
             "🍔 Welcome to CryptoBites! 🍟\n\n" +
             "Where technology meets taste, right in the heart of Bayombong, Nueva Vizcaya.\n\n" +
             "At CryptoBites, every dish is inspired by digital culture — " +
             "from blockchain burgers to byte-sized snacks. " +
             "We pride ourselves on using fresh ingredients and bringing innovative flavors to your plate.\n\n" +
             "Founded by a team of food enthusiasts and tech explorers, " +
             "our mission is to combine fun, flavor, and convenience in every meal.\n\n" +
             "Whether you’re here for a quick lunch, a casual dinner, or a tech-inspired snack, " +
             "CryptoBites is your go-to spot for delicious, creative meals.\n\n" +
             "📍 Location: Bayombong, Nueva Vizcaya\n" +
             "💻 Connect with us online for promotions and updates.\n\n" +
             "Thank you for choosing CryptoBites — where your cravings meet creativity!";
            MessageBox.Show(aboutText, "About CryptoBites", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cart.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"User: {username}\nEnjoy CryptoBites! Enjoy your Meal",
                          "Account Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnviewcart_Click(object sender, EventArgs e)
        {
            string summary = cart.GetCartSummary();

            MessageBox.Show(summary,
                            "Your Order",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnBurger_Click(object sender, EventArgs e)
        {
            int qty = (int)numericUpDownBurger.Value;
            cart.AddItemToCart("Crypto Burger", 129.00m, qty);
            numericUpDownBurger.Value = 0;
        }

        private void numericUpDownBurger_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownBurger.Value < 0)
                numericUpDownBurger.Value = 0;
        }

        private void btnFries_Click(object sender, EventArgs e)
        {
            int qty = (int)numericUpDownFries.Value;
            cart.AddItemToCart("Blockchain Fries", 89.00m, qty);
            numericUpDownFries.Value = 0;
        }

        private void numericUpDownFries_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownFries.Value < 0)
                numericUpDownFries.Value = 0;
        }


        private void btnChicken_Click(object sender, EventArgs e)
        {
            int qty = (int)numericUpDownChicken.Value;
            cart.AddItemToCart("Satoshi Chicken", 149.00m, qty);
            numericUpDownChicken.Value = 0;
        }

        private void numericUpDownChicken_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownChicken.Value < 0)
                numericUpDownChicken.Value = 0;
        }


        private void btnpizza_Click(object sender, EventArgs e)
        {
            int qty = (int)numericUpDownpizza.Value;
            cart.AddItemToCart("Crypto Pizza", 199.00m, qty);
            numericUpDownpizza.Value = 0;
        }

        private void numericUpDownpizza_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownpizza.Value < 0)
                numericUpDownpizza.Value = 0;
        }

        private void btnhotdog_Click(object sender, EventArgs e)
        {
            int qty = (int)numericUpDownhotdog.Value;
            cart.AddItemToCart("Blockchain Hotdog", 79.00m, qty);
            numericUpDownhotdog.Value = 0;
        }

        private void numericUpDownhotdog_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownhotdog.Value < 0)
                numericUpDownhotdog.Value = 0;
        }
        private void btnpancit_Click(object sender, EventArgs e)
        {
            int qty = (int)numericUpDownpancit.Value;
            cart.AddItemToCart("Crypto Pancit", 99.00m, qty);
            numericUpDownpancit.Value = 0;
        }

        private void numericUpDownpancit_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownpancit.Value < 0)
                numericUpDownpancit.Value = 0;
        }

    }
}



