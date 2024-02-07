using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

enum Rodzaj
{
    normal,expres,lux
}

namespace spr_cs
{
    public partial class Form1 : Form
    {

        private double kilometry;
        private int ludzie;
        private Rodzaj rodzaj;
        private bool uczeń;
        private double dodatki;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kilometry = Convert.ToDouble(textBox1.Text);
            ludzie = Convert.ToInt32(textBox2.Text);
            uczeń = radioButton1.Checked;
            dodatki = 0;
            if (checkBox1.Checked)
                dodatki += 20;
            if(checkBox2.Checked)
                dodatki += 8;
            double wynik = kilometry * ludzie;
            if (rodzaj == Rodzaj.expres)
                wynik *= 1.2;
            if (rodzaj == Rodzaj.lux)
                wynik *= 1.4;
            if (uczeń)
                wynik *= 0.9;
            wynik += dodatki;
            output.Text = Convert.ToString(wynik)+"zł";
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            rodzaj = (Rodzaj)comboBox1.SelectedIndex;
        }
    }
}
