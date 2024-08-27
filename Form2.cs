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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //ScrollText();
        }
        public void ScrollText()
        {
            String message = "THE POISON IS BLATANT. YOU KNOW IT IS THERE";
            this.INFO.Text = "";
            for (int i = 0; i < message.Length; i++)
            {
                // Extend window to make sure everything fits.
                if (i >= 30) { }
                this.INFO.Text += message[i];
                Task.Delay(100).Wait();
            }
        }
    }
}
