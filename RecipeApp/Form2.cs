using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeApp
{
    public partial class Form2 : Form
    {

        public static Form2 instance;
        public static Label lbl;
        public String ingname;
        public String mu ;
        public float mquantity ;
        public int calories;
        public String fg;


        public Form2()
        {
            InitializeComponent();
            instance = this;
            lbl = label1;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {



            

            if (tbname.Text.Equals("") || cbmeasuringunit.Text.Equals("") || tbmquantity.Text.Equals("") || tbcalories.Text.Equals(""))
            {

                lblerror.Text = "Makw sure that all fields are Properly filled in!";

            }
            else
            {
                this.Close(); // this code closes the form
                ingname = tbname.Text; // this code stores the user input into the public variables
                mu = cbmeasuringunit.Text;
                mquantity = float.Parse(tbmquantity.Text);
                calories = Convert.ToInt32(tbcalories.Text);
                fg = tbfg.Text;

                Class1 class1 = new Class1();

                class1.ingredientName = ingname;
                class1.Measurementunit = mu;
                class1.MUquantity = mquantity;
                class1.Ingredientcalories = calories;
                class1.IngredientfoodGroup = fg;

                
            }


        }
    }
}
