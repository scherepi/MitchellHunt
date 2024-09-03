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
        }
        public void ScrollText()
        {
            // The original message
            String message = "THE POISON IS BLATANT. YOU KNOW IT IS THERE. TEGASCUS SEVNUN NAK RAMA. ELLT EKNA POVIK SELUM. LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            Console.WriteLine("Current msg length: " + message.Length);
            this.INFO.Text = "";
            this.line2.Text = "";
            for (int i = 0; i < message.Length; i++)
            {
                // Extend window first to make sure everything fits.
                if (i >= 30 && i < 93) { this.Width += 12; }
                if (i < 93) { this.INFO.Text += message[i]; }
                // Then, once we've lengthened, we go for the second line.
                if (i >= 93) { this.line2.Text += message[i];  }
                Task.Delay(100).Wait();
            }
        }
    }
}
