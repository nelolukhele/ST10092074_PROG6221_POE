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
    public partial class Form6 : Form
    {

        public static Form6 Instance;
        public static RichTextBox rtb;
        public Form6()
        {
            
            InitializeComponent();
            Instance = this;
            rtb = rtbdisplay;
            
        }

        private void rtbdisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
