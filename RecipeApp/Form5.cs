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
    public partial class Form5 : Form
    {

        public static Form5 Instance;
        public static RichTextBox rtb;
        public int rnum;
        public Form5()
        {
            InitializeComponent();
            Instance = this;
            rtb = rtbdisplay;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            
            


        }

        private void rtbdisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbrnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 class1 = new Class1();

            rnum = Convert.ToInt32(tbrnum.Text);

            class1.dr = rnum;

            this.Close();
        }
    }
}
