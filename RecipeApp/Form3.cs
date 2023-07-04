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
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            String name;
            int ingnum;
            int steps;


            if (txtname.Text.Equals("") || txtnuming.Text.Equals("") || txtsteps.Text.Equals("")) 
            {

                lblerror.Text = "Makw sure that all fields are Properly filled in!";
            
            }

            else
            {

                

                name = txtname.Text;
                ingnum = Convert.ToInt32(txtnuming.Text);
                steps = Convert.ToInt32(txtsteps.Text);

                
                Class1 class1 = new Class1();
                class1.AddRecipe(name, ingnum, steps);
                this.Close();

            }
            
        }
        
    }
}
