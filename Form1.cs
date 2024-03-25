using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace LibreriaG
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double suma = (Convert.ToInt32 (textBox1.Text)*00.05 )+ ( Convert.ToInt32(color.Text) * 00.10);
            total.Text = Convert.ToString(suma);

        } 


        public void borrar()
        {
            textBox1.Text = "0";    
            color.Text = "0";   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pago pg = new Pago();
            pg.Show();

        }
    }
}
