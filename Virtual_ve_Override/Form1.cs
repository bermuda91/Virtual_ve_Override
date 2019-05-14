using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virtual_ve_Override
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            personel p1 = new personel();
            p1.Adi = textBox1.Text;
            p1.Soyadi = textBox2.Text;
            p1.Dogum_Tarihi = dateTimePicker1.Value;

            listBox1.Items.Add(p1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Avrupa avp1 = new Avrupa();
            MessageBox.Show(avp1.Mesajver()); 
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Amerika amr1 = new Amerika();
            MessageBox.Show(amr1.Mesajver());
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Asya asy1 = new Asya();
            MessageBox.Show(asy1.Mesajver());
        }
    }
}
