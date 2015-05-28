using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        Double deger = 0;
        String hesap = "";
        bool hesap_yapildiginda = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((ekran.Text == "0") || (hesap_yapildiginda))
                ekran.Clear();

            hesap_yapildiginda = false;
            Button tus = (Button)sender;
            if(tus.Text ==".")
            {
                if (!ekran.Text.Contains("."))
                    ekran.Text = ekran.Text + tus.Text;
            }
            else
            ekran.Text = ekran.Text + tus.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ekran.Text = "0";
        }


        private void hesap_Click(object sender, EventArgs e)
        {
            Button tus = (Button)sender;

            if (deger != 0)
            {
                esittir.PerformClick();
                hesap_yapildiginda = true;
                hesap = tus.Text;
                hesaplama.Text = deger + " " + hesap;

            }
            hesap = tus.Text;
            deger = Double.Parse(ekran.Text);
            hesap_yapildiginda = true;
            hesaplama.Text = deger + " " + hesap;
            

        }

        private void button18_Click(object sender, EventArgs e)
        {
            
            hesaplama.Text = "";
            switch (hesap)
            {
                case "+":
                    ekran.Text = (deger + Double.Parse(ekran.Text)).ToString();
                    break;

                case "-":
                    ekran.Text = (deger - Double.Parse(ekran.Text)).ToString();
                    break;

                case "*":
                    ekran.Text = (deger * Double.Parse(ekran.Text)).ToString();
                    break;

                case "/":
                    ekran.Text = (deger / Double.Parse(ekran.Text)).ToString();
                    break;

                default:
                    break;
            }
            deger = Double.Parse(ekran.Text);
            hesap = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ekran.Text = "0";
            deger = 0;

        }

        private void label1_Click(object sender, EventArgs e)
        {
          

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar.ToString())
            {
                case "0":
                    sifir.PerformClick();
                    break;
                case "1":
                    bir.PerformClick();
                    break;
                case "2":
                    iki.PerformClick();
                    break;
                case "3":
                    uc.PerformClick();
                    break;
                case "4":
                    dort.PerformClick();
                    break;
                case "5":
                    bes.PerformClick();
                    break;
                case "6":
                    alti.PerformClick();
                    break;
                case "7":
                    yedi.PerformClick();
                    break;
                case "8":
                    sekiz.PerformClick();
                    break;
                case "9":
                    dokuz.PerformClick();
                    break;
                case "+":
                    toplama.PerformClick();
                    break;
                case "-":
                    cikarma.PerformClick();
                    break;
                case "/":
                    bolme.PerformClick();
                    break;
                case "*":
                    carpma.PerformClick();
                    break;
                
                default:
                    break;
            }
        }

      
    }
}
