using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul2_1302204002
{
    public partial class Form1 : Form
    {
        double nilai_angka = 0;
        string x = "";
        bool ditekan = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || (ditekan))
            {
                ditekan = false;
                textBox1.Clear();
            }

            Button b = (Button)sender;
            textBox1.Text += b.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            x = b.Text;
            nilai_angka = Double.Parse(textBox1.Text);
            ditekan = true;
        }

        private void hitung(object sender, EventArgs e)
        {
            if(x == "+")
            {
                textBox1.Text = (nilai_angka + Double.Parse(textBox1.Text)).ToString();
            }
        }
    }
}
