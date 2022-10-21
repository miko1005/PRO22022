using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RačunanjeKompleksnihŠtevil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 
        private void btnPlus_Click(object sender, EventArgs e)
        {
            Kompleksno prvo = new Kompleksno(0,0);
            prvo.Re = double.Parse(textBox1.Text);
            prvo.Im = double.Parse(textBox2.Text);
            Kompleksno drugo = new Kompleksno(0,0);
            drugo.Re = double.Parse(textBox3.Text);
            drugo.Im = double.Parse(textBox4.Text);
            labRez.Text = (prvo + drugo).ToString();
         
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
           
            Kompleksno prvo = new Kompleksno(0,0);
            prvo.Re = double.Parse(textBox1.Text);
            prvo.Im = double.Parse(textBox2.Text);
            Kompleksno drugo = new Kompleksno(0,0);
            drugo.Re = double.Parse(textBox3.Text);
            drugo.Im = double.Parse(textBox4.Text);
            labRez.Text = (prvo-drugo).ToString();
        }
        private void btnKrat_Click(object sender, EventArgs e)
        {
 
            Kompleksno prvo = new Kompleksno(0,0);
            prvo.Re = double.Parse(textBox1.Text);
            prvo.Im = double.Parse(textBox2.Text);
            Kompleksno drugo = new Kompleksno(0,0);
            drugo.Re = double.Parse(textBox3.Text);
            drugo.Im = double.Parse(textBox4.Text);
            labRez.Text = (prvo*drugo).ToString();
        }
    }
}
