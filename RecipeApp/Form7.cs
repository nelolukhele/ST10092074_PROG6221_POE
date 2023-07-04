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
    public partial class Form7 : Form
    {

        public static Form7 Instance;
        public static RichTextBox rtb;
        public int rnum;
        public double scale;
        public Boolean option = true;

        public Form7()
        {
            InitializeComponent();
            Instance = this;
            rtb = rtbdisplay;
        }

        private void rtbdisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnscale_Click(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();

            if (tbrecipenum.Text.Equals("") || cbscaleby.Text.Equals(""))
            {

                MessageBox.Show("Make sure you have filled in everything","Error");

            }
            else
            {
                
                rnum = Convert.ToInt16(tbrecipenum.Text);

                scale = Convert.ToDouble(cbscaleby.Text);

                
                this.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}
