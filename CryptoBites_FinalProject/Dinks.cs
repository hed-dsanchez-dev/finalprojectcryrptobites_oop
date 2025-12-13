using System;
using System.Windows.Forms;

namespace CryptoBites_FinalProject
{
    public partial class Dinks : Form
    {
        private Cart cart;       // reference to Cart
        private string username; // logged-in username

        public Dinks(Cart currentCart, string loggedInUser)
        {
            InitializeComponent();
            cart = currentCart;
            username = loggedInUser;
        }

        // Back to Cart
        private void btnBack_Click(object sender, EventArgs e)
        {
            cart.Show();
            this.Close();
        }

        // Add drinks to Cart
        private void pictureBoxLemonade_Click(object sender, EventArgs e)
        {
            cart.AddItemToCart("Lemonade", 50.00m, 1);
        }

        private void pictureBoxSoda_Click(object sender, EventArgs e)
        {
            cart.AddItemToCart("Soda", 40.00m, 1);
        }

        // Account button → show welcome message
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Welcome to CryptoBites, {username}!", "Account Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click1(object sender, EventArgs e)
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

        private void label4_Click(object sender, EventArgs e) { }

        private void btnfood_Click(object sender, EventArgs e)
        {
            Foods FoodsForm = new Foods(cart, username);
            FoodsForm.Show();
            this.Hide();
        }

        private void btndrinks_Click(object sender, EventArgs e)
        {
            // Already in Dinks form, just show the info
            MessageBox.Show("Please select Drinks.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cart.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"User: {username}\nEnjoy CryptoBites! Enjoy your Meal",
                            "Account Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            string summary = cart.GetCartSummary();

            MessageBox.Show(summary,
                            "Your Order",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
