using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaPizzaPos
{
    public partial class MediumToppings : Form
    {
        public MediumToppings()
        {
            InitializeComponent();
        }

        private void Anchovy_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " Anchovy,";
        }

        private void MediumToppings_Load(object sender, EventArgs e)
        {

        }

        private void MedOrder_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bacon_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " Bacon,";
        }

        private void No_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " NO ";
        }

        private void Beef_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " Beef,";
        }

        private void Capicola_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " Capicola,";
        }

        private void Ham_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " Ham,";
        }

        private void Pepperoni_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " Pepperoni,";
        }

        private void Sausage_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " Sausage,";
        }

        private void Turkey_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " Turkey,";
        }

        private void BananaPepper_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " Banana Pepper,";
        }

        private void BlackOlive_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " Black Olive,";
        }

        private void Garlic_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " Garlic,";
        }

        private void GreenOlive_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " Green Olive,";
        }

        private void GreenPeppers_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " Green Pepper,";
        }

        private void Mushroom_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " Mushroom,";
        }

        private void Onion_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " Onion,";
        }

        private void Pepperoncini_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " Pepperoncini,";
        }

        private void Spinach_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " Spinach,";
        }

        private void Tomato_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " Tomato,";
        }

        private void Roberto_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " Roberto,";
        }

        private void DeluxeVeggie_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " Deluxe Veggie,";
        }

        private void DeluxeMeat_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " Deluxe Meat,";
        }

        private void ExtraCheese_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " Extra Cheese,";
        }

        private void ExtraSauce_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " Extra Sauce,";
        }

        private void NoCheese_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " NO CHEESE ";
        }

        private void NoSauce_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " NO SAUCE ";
        }

        private void HalfButton_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " 1/2 ";
        }

        private void WellDone_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " WELL DONE ";
        }

        private void HalfBaked_Click(object sender, EventArgs e)
        {
            MedOrder.Text = MedOrder.Text + " HALF BAKED ";
        }
    }
}
