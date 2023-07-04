using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeApp
{
    public partial class Form4 : Form
    {

        public string description;
        public Form4()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {

            if (tbadd.Text.Equals(""))
            {

                lblerror.Text = "Makw sure that all fields are Properly filled in!";

            }
            else
            {
                this.Close();
                Class1 class1 = new Class1();

                description = tbadd.Text;
            }

        }
    }
}
