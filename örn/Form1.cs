using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace örn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adet;
            double toplam;
            adet = Convert.ToInt16(textBox1.Text);
            if (adet>=0 && adet<=20)
            {
                toplam = (adet * 8) - (adet * 8 * 0.20);
                label4.Text = toplam + "TL";
            
            }
            if (adet>=21 && adet<=40)
            {
                toplam = (adet * 8) - (adet * 8 * 0.40);
                label4.Text = toplam + "TL";
            }
            if (adet > 41) 
            {
                toplam = (adet * 8) - (adet * 8 * 0.50);
                label4.Text = toplam + "TL";

            }
        }
    }
}
