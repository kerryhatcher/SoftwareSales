using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareSales
{
    public partial class Form1 : Form
    {

        public const int PakA = 150;
        public const int PakB = 120;
        public const int PakC = 90;
        public Form1()
        {
            InitializeComponent();
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {

            int PakAtotal = PakA * Convert.ToInt32(textBoxPakA.Text);
            int PakBtotal = PakB * Convert.ToInt32(textBoxPakB.Text);
            int PakCtotal = PakC * Convert.ToInt32(textBoxPakC.Text);

            textBoxPakAtotal.Text = Convert.ToString(PakAtotal);
            textBoxPakBtotal.Text = Convert.ToString(PakBtotal);
            textBoxPakCtotal.Text = Convert.ToString(PakCtotal);
            textBoxTotal.Text = Convert.ToString(PakAtotal + PakBtotal + PakCtotal); 





        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

            textBoxPakA.Clear();
            textBoxPakB.Clear();
            textBoxPakC.Clear();
            textBoxPakAtotal.Clear();
            textBoxPakBtotal.Clear();
            textBoxPakCtotal.Clear();
            textBoxTotal.Clear();


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
