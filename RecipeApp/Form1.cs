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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();
            class1.ScaleARecipe(); // this code opens the form
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog(); // this code opens the form


        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();
            class1.DisplayARecipe(); // this code opens the form
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close(); // this closes the application
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();
            class1.ResetARecipe(); // this code opens the form
        }
    }
}
