using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MitchellHunt
{
    public partial class Form1 : Form
    {
        private int numTries = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            String entered = this.txtEntry.Text;
            if (entered == "PNIZURR") {
                Form2 f2 = new Form2();
                f2.Show();
                f2.ScrollText();
                this.btnEnter.Enabled = false;
            } else
            {
                this.txtEntry.Text = "";
                this.lblIncorrect.Text = "INCORRECT - " + Convert.ToString(numTries - 1) + " TRIES LEFT";
                numTries--;
                if (numTries == 0)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
        }
    }
}
